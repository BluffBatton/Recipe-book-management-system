SELECT b.BookId, b.Title AS BookTitle, u.FirstName, u.LastName
FROM Book b JOIN [User] u ON b.UserId = u.UserId;

SELECT r.RecipeId, r.Title AS RecipeTitle, r.Ingredients, r.Instructions
FROM Recipe r WHERE r.BookId = 1;

SELECT u.UserId, u.FirstName, u.LastName, COUNT(b.BookId) AS BookCount
FROM [User] u LEFT JOIN Book b ON u.UserId = b.UserId
GROUP BY u.UserId, u.FirstName, u.LastName;

SELECT r.RecipeId, r.Title, r.Ingredients
FROM Recipe r WHERE r.Ingredients LIKE '%Cheese%';