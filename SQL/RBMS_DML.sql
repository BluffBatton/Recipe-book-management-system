-- Insert Users
INSERT INTO [User] (FirstName, LastName, Email, PhoneNumber, [Password]) VALUES
('Mykyta', 'Smith', 'mykyta@example.com', '1234567899', 'mykytacool'),
('Danylo', 'Johnson', 'danylo@example.com', '9874561233', 'danylocool'),
('Sanek', 'Sinn', 'sanek@example.com', '8527419638', 'saneksinn');

INSERT INTO Book (Title, [Description], UserId) VALUES
('Mykyta`s cook', 'See my cool recipes for dot net people', 1),
('Mykyta`s cook pt2', 'See my cool recipes for dot net people, but better', 1),
('Danylo`s meals', 'Enjoy my healthy meals all day long', 2),
('Danylo`s meals pt2', 'Enjoy my very healthy meals all week long', 2),
('Sanek`s cookbook', '30-Minute Recipes from an Italian Kitchen', 3),
('Sanek`s cookbook pt2', 'The Art of Italian Cooking', 3);

INSERT INTO Recipe (Title, Ingredients, Instructions, BookId) VALUES
('Spaghetti', 'Pasta, Tomato, Salt', 'Boil pasta. Add sauce.', 1),
('Salad', 'Lettuce, Tomato, Dressing', 'Mix ingredients.', 1),
('Soup', 'Water, Vegetables', 'Boil all together.', 1),

('Pizza', 'Dough, Cheese, Sauce', 'Bake at 450.', 2),
('Tacos', 'Shells, Meat, Cheese', 'Assemble and serve.', 2),
('Omelette', 'Eggs, Salt, Vegetables', 'Cook on pan.', 2),

('Grilled Chicken', 'Chicken, Spices', 'Grill for 20 mins.', 3),
('Smoothie', 'Fruits, Yogurt', 'Blend well.', 3),
('Pancakes', 'Flour, Milk, Eggs', 'Cook on skillet.', 3),

('Burger', 'Bun, Patty, Lettuce', 'Assemble and grill.', 4),
('Fries', 'Potatoes, Oil, Salt', 'Fry until golden.', 4),
('Stir Fry', 'Veggies, Soy Sauce', 'Stir fry in wok.', 4),

('Stew', 'Meat, Vegetables', 'Simmer for 2 hrs.', 5),
('Bread', 'Flour, Yeast, Water', 'Bake for 40 mins.', 5),
('Cake', 'Flour, Sugar, Eggs', 'Bake at 350F.', 5),

('Lasagna', 'Pasta, Cheese, Sauce', 'Bake in layers.', 6),
('Curry', 'Chicken, Spices, Cream', 'Simmer gently.', 6),
('Rice', 'Rice, Water, Salt', 'Boil till cooked.', 6);

--UPDATE Recipe SET Title = 'Spaghetti Bolognese', Instructions = 'Boil pasta. Cook meat with sauce. Combine.' WHERE RecipeId = 1;

--DELETE FROM Recipe WHERE RecipeId = 2;