--drop procedure InnerJoin
Create Procedure InnerJoin
(
@CustomerId int
)
AS
BEGIN
Select c.CustomerId, c.CustomerName, c.CustomerEmail, c.CustomerOrderHistory, c.Reviews,
o.OrderedProducts, o.OrderDate, o.TotalAmount from
Customers as c
inner join
OrderTableInfos as o
on
c.customerId = o.CustomerId
Where
c.CustomerId = @CustomerId
END

exec InnerJoin 1





create procedure InnerJoin1
AS
BEGIN
Select c.CustomerId, c.CustomerName, c.CustomerEmail, c.CustomerOrderHistory, c.Reviews,
STRING_AGG
	(CONCAT
		(
        'OrderedProducts: ', o.OrderedProducts, CHAR(13) + CHAR(10) +
        'OrderDate: ', o.OrderDate, CHAR(13) + CHAR(10) +
        'TotalAmount: ', o.TotalAmount
		), 
	CHAR(13) + CHAR(10) + '----' + CHAR(13) + CHAR(10)
	)
AS OrderDetails
FROM Customers c
INNER JOIN
OrderTableInfos o
ON
c.CustomerId = o.CustomerId
GROUP BY
    c.CustomerId,
    c.CustomerName,
    c.CustomerEmail,
	c.CustomerOrderHistory, 
	c.Reviews;
END

exec InnerJoin1
