using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToCookForm.Models
{
    internal class DishesDAO
    {
        string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=WTCContext;Integrated Security=SSPI;";

        public Ingredient findIngredientByName(string ingName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Id, Name, Gluten, Vegan, Vegeterian, TransFat, SimpleSugar, Lactose, Fiber FROM Ingredients WHERE Name = @ingName", connection);
            command.Parameters.AddWithValue("@ingName", ingName);
            Ingredient ingredient = new Ingredient();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ingredient i = new Ingredient
                    {
                        Id = reader.GetInt16(0),
                        Name = reader.GetString(1),
                        Gluten = reader.GetBoolean(2),
                        Vegan = reader.GetBoolean(3),
                        Vegeterian = reader.GetBoolean(4),
                        TransFat = reader.GetBoolean(5),
                        SimpleSugar = reader.GetBoolean(6),
                        Lactose = reader.GetBoolean(7),
                        Fiber = reader.GetBoolean(8)
                    };
                    ingredient = i;
                }

            }

            connection.Close();
            return ingredient;
        }

        public int findIngredientId(string ingName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Id FROM Ingredients WHERE Name = @ingName", connection);
            command.Parameters.AddWithValue("@ingName", ingName);
            int id = new int();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ingredient i = new Ingredient
                    {
                        Id = reader.GetInt32(0),
                    };
                    id = i.Id;
                }
            }
            connection.Close();
            return id;
        }

        public int findDishId(string dishName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Id FROM Dishes WHERE Name = @dishName", connection);
            command.Parameters.AddWithValue("@dishName", dishName);
            int id = new int();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dish d = new Dish
                    {
                        Id = reader.GetInt32(0),
                    };
                    id = d.Id;
                }
            }
            connection.Close();
            return id;
        }

        internal void addOneDishWithIngredients(Dish dish, List<string> dishIngredientNames)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Dishes (Name) VALUES (@name);", connection);
            command.Parameters.AddWithValue("@name", dish.Name);
            command.ExecuteNonQuery();
            connection.Close();
            var dishId = findDishId(dish.Name);
            
            foreach(string i in dishIngredientNames)
            {
                SqlConnection connection1 = new SqlConnection(connectionString);
                connection1.Open();
                var ingId = findIngredientId(i);
                SqlCommand command2 = new SqlCommand("INSERT INTO IngredientDishes (Ingredient_Id, Dish_Id) VALUES (@Ingredient_Id, @Dish_Id)", connection1);
                command2.Parameters.AddWithValue("@Ingredient_Id", ingId);
                command2.Parameters.AddWithValue("@Dish_Id", dishId);
                command2.ExecuteNonQuery();
                command2.Parameters.Clear();
                connection1.Close();
            }
        }

        public List<Dish> getAllDishes()
        {
            List<Dish> dishesWOIngredients = new List<Dish>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Id, Name FROM Dishes", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dish i = new Dish
                    {
                        Id= reader.GetInt32(0),
                        Name = reader.GetString(1),
                    };
                    dishesWOIngredients.Add(i);
                }
            }
            connection.Close();

            foreach(Dish d in dishesWOIngredients)
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                SqlConnection connection1 = new SqlConnection(connectionString);
                connection1.Open();
                SqlCommand command1 = new SqlCommand("SELECT  i.Id, i.Name, Gluten, Vegan, Vegeterian, TransFat, SimpleSugar, Lactose, Fiber FROM Ingredients" +
                    " as i INNER JOIN IngredientDishes as di ON i.Id = di.Ingredient_Id INNER JOIN Dishes as d ON di.Dish_Id = d.Id WHERE d.Id = @dishId", connection1);
                command1.Parameters.AddWithValue("@dishId", d.Id);
                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ingredient i = new Ingredient
                        {
                            Name = reader.GetString(1),
                            Gluten = reader.GetBoolean(2),
                            Vegan = reader.GetBoolean(3),
                            Vegeterian = reader.GetBoolean(4),
                            TransFat = reader.GetBoolean(5),
                            SimpleSugar = reader.GetBoolean(6),
                            Lactose = reader.GetBoolean(7),
                            Fiber = reader.GetBoolean(8),
                        };
                        ingredients.Add(i);
                    }
                }
                d.Ingredients = ingredients;
                command1.Parameters.Clear();
                connection1.Close();
            }
            return dishesWOIngredients;
        }
    }
}
