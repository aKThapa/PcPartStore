# PcPartStore
Here are all my codes, written in C#, MVC, ASP.NET and HTML for my Back End Web Development Project, PcPartStore. It is a multi database 
Ecommerce type website. All the information that is being displayed on the screen are coming from their own Database.

For e.g, CPU and GPU, which are navigation links on my ".net" website ,take you to their own different page, with their own custom theme,
and so every page looks different. All the information of the products, are coming from their own, respective databases. It's a 
multi-database MVC project. 


Since, the information of products are coming from different databases, with their own unique tables and their own 
criteria for the products. There was no guarantee that, every products would receive a unique productID because unqiue IDs among different
tables in a different database are going to match. 

So, I had to account for this by making a new list. Then, concatinating the information and transforming it into a form the list requires and 
then adding it to the list.The lists are then given their own unique id, through the use of a static class, IDsetter. This ensures that every
product will now get their own ids. Now, from the summary page you can also delete the items you dont want from your shopping basket. 

The, layout of the pages are 3 columns and it will remain constant, no matter, however many products are added into the database. Use of loops,
counters and bootstrap's 3 column layout ensures this happens all the time. By default all the pages in a MVC website share a single 
_Layout.cshtml page. That's why every page looks same. I didn't wanted to stick to this limitation. So, I made some few different classes 
in the CSS page, gave them their own attributes, and called the class from the body of the _Layout.cshtml, during runtime. 

All the codes were written by myself, Copyright. Hope you Enjoy!!!!!!!!! my .Net Web Application.




