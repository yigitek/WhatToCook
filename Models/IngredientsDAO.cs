using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToCookForm.Models
{
    internal class IngredientsDAO
    {
        string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=WTCContext;Integrated Security=SSPI;";
        public List<Ingredient> getAllIngredients()
        {
            List<Ingredient> returnThese = new List<Ingredient>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Id, Name, Gluten, Vegan, Vegeterian, TransFat, SimpleSugar, Lactose, Fiber FROM Ingredients", connection);
            
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ingredient i = new Ingredient
                    {
                        Name = reader.GetString(1),
                        Gluten = reader.GetBoolean(2),
                        Vegan= reader.GetBoolean(3),
                        Vegeterian= reader.GetBoolean(4),
                        TransFat= reader.GetBoolean(5),
                        SimpleSugar= reader.GetBoolean(6),
                        Lactose= reader.GetBoolean(7),
                        Fiber= reader.GetBoolean(8),
                    };
                    returnThese.Add(i);
                }
            }
            connection.Close();
            returnThese.OrderBy(n =>n.Name).ToList();
            return returnThese;
        }

        internal void deleteIngredients (List<Ingredient> ingredientsToDel)
        {
            foreach(Ingredient i in ingredientsToDel)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Ingredients WHERE Name=@name; VALUES (@name);", connection);
                command.Parameters.AddWithValue("@name", i.Name);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        internal void addOneIngredient(Ingredient ingredient)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Ingredients (Name, Gluten, Vegan, Vegeterian," +
                " TransFat, SimpleSugar, Lactose, Fiber) VALUES (@name, @gluten, @vegan, @vegeterian, @transfat," +
                " @sugar, @lactose, @fiber);", connection);

            command.Parameters.AddWithValue("@name", ingredient.Name);
            command.Parameters.AddWithValue("@gluten", ingredient.Gluten);
            command.Parameters.AddWithValue("@vegan", ingredient.Vegan);
            command.Parameters.AddWithValue("@vegeterian", ingredient.Vegeterian);
            command.Parameters.AddWithValue("@transfat", ingredient.TransFat);
            command.Parameters.AddWithValue("@sugar", ingredient.SimpleSugar);
            command.Parameters.AddWithValue("@lactose", ingredient.Lactose);
            command.Parameters.AddWithValue("@fiber", ingredient.Fiber);
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
