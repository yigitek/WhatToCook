using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WhatToCookForm.Models;

namespace WhatToCookForm
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=WTCContext;Integrated Security=SSPI;";
        BindingSource ingredientBindingSource = new BindingSource();
        BindingSource dishBindingSource = new BindingSource();

        List<Ingredient> ingredients = new List<Ingredient>();
        List<Ingredient> ingredientsToDelete = new List<Ingredient>();
        List<Ingredient> dishIngredients = new List<Ingredient>();
        List<string> dishIngredientNames = new List<string>();
        private bool _noise;
        private bool _noiseDel;
        public bool vegan;
        public bool vegeterian;
        public bool lactose;
        public bool gain;
        public bool lose;
        public bool gluten;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngredientsDAO ingredientsDAO = new IngredientsDAO();

            ingredientBindingSource.DataSource = ingredientsDAO.getAllIngredients();
            //dataGridView1.DataSource = ingredientBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = txt_ingName.Text,
                Gluten = bool_gluten.Checked,
                Vegan = bool_vegan.Checked,
                Vegeterian = bool_vegeterian.Checked,
                TransFat = bool_transFat.Checked,
                SimpleSugar = bool_simpleSugar.Checked,
                Lactose = bool_lactose.Checked,
                Fiber = bool_fiber.Checked
            };
            IngredientsDAO ingredientsDAO = new IngredientsDAO();
            ingredientsDAO.addOneIngredient(ingredient);
            MessageBox.Show($"Ingredient {ingredient.Name} was succesfully created");
        }

        private void txt_ingName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            _noise = true;
            _noiseDel= true;
            cBoIngAll.DisplayMember = "Name";
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";
            //listBox3.DisplayMember = "Name";
            //cboIngDel.DisplayMember = "Name";
            IngredientsDAO ingredientsDAO = new IngredientsDAO();
            ingredientBindingSource.DataSource = ingredientsDAO.getAllIngredients();
            cBoIngAll.DataSource = ingredientBindingSource;
            //cboIngDel.DataSource = ingredientBindingSource;

            _noise = false;
            _noiseDel = false;
        }
        //private void cboIngDel_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (_noiseDel) return;
        //    _noise = true;
        //    Ingredient slctdIngredientToDel = (Ingredient)cboIngDel.SelectedItem;
        //    var selectedIngredientToDelName = slctdIngredientToDel.Name;
        //    listBox3.Items.Add(selectedIngredientToDelName);
        //    ingredientsToDelete.Add(slctdIngredientToDel);
        //    _noise = false;
        //}

        private void cBoIngAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_noise) return;
            Ingredient slctdIngredient = (Ingredient)cBoIngAll.SelectedItem;
            var selectedIngredientName = slctdIngredient.Name;
            listBox1.Items.Add(selectedIngredientName);
            dishIngredientNames.Add(selectedIngredientName.ToString());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            Dish dish = new Dish
            {
                Name = txtDishName.Text,
                Ingredients = ingredients
            };
            DishesDAO dishesDAO1 = new DishesDAO();
            dishesDAO1.addOneDishWithIngredients(dish, dishIngredientNames);
            MessageBox.Show($"Recipe {dish.Name} was succesfully created");
            listBox1.Items.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxVegan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            vegan = checkBoxVegan.Checked;
            vegeterian= checkBoxVegeterian.Checked;
            lactose = checkBoxLactose.Checked;
            gain= checkBoxGain.Checked;
            lose = checkBoxLose.Checked;
            gluten = checkBoxGluten.Checked;
            List<Dish> dishes = new List<Dish>();
            DishesDAO dishesDAO1 = new DishesDAO();
            dishes = dishesDAO1.getAllDishes();
            var returnDishes = dishes.Select(s => new Dish { Name = s.Name, Ingredients = s.Ingredients }).ToList();

            if (vegan is true)
            {
                foreach (Dish d in dishes)
                {
                    if(d.Ingredients.Any(i => i.Vegan != true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                }                
            }
            if (vegeterian is true)
            {
                foreach (Dish d in dishes)
                {
                    if (d.Ingredients.Any(i => i.Vegeterian != true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                }
            }
            if (lactose is true)
            {
                foreach (Dish d in dishes)
                {
                    if (d.Ingredients.Any(i => i.Lactose == true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                }
            }
            if (gluten is true)
            {
                foreach (Dish d in dishes)
                {
                    if (d.Ingredients.Any(i => i.Gluten == true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                }
            }
            if (gain is true)
            {
                foreach (Dish d in dishes)
                {
                    if (d.Ingredients.Any(i => i.Fiber == true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                }
            }
            if (lose is true)
            {
                foreach (Dish d in dishes)
                {
                    if (d.Ingredients.Any(i => i.TransFat == true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                    if (d.Ingredients.Any(i => i.SimpleSugar == true))
                    {
                        Dish toRemove = returnDishes.FirstOrDefault(dtr => dtr.Name == d.Name);
                        returnDishes.Remove(toRemove);
                    }
                }
            }
            foreach(Dish d in returnDishes)
            {
                listBox2.Items.Add(d);
            }
        }

        private void findClear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngredientsDAO ingredientsDAO = new IngredientsDAO();
            ingredientsDAO.deleteIngredients(ingredientsToDelete);
        }
    }
}
//public bool vegan;
//public bool vegeterian;
//public bool lactose;
//public bool gain;
//public bool lose;
//public bool gluten;