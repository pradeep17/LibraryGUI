LibraryGUI
==========

Final version of Library application source files


Feature #1: Easy and fast checkout
       Located at: “Books Availability” Tab page
Details:
1.	Once the user searches for a book, a grid view result is displayed.
2.	The user is now presented with a separate column with buttons along with the result.
3.	Now, the user can click on any button and the corresponding row (with the Book ID and Branch ID) is selected for check out and the user is directly taken to the Check Out tab page
without having to manually navigate and enter the same in the Check Out page.


Feature #2: Clear selection and check out review functionalities
Located at: “Check out” Tab page
Details:
1.	If the user was directed to Check out tab page from the Books Availability page by clicking 
“Proceed to check out” button, the Book ID and Branch ID fields are disabled. But the user can make these fields accessible again and also clear the previous selection by clicking on “Clear selection” button if the user decides to enter these fields manually to search.
2.	In the “Check out” tab page, the user can click on the “Show check out items” to review the 
details of the check out before confirming check out.

Feature #3: Check out summary results
Located at: “Check out” Tab page
Details:
1.	Once the user confirms check out of a book, the user is shown a check out summary in the same grid view.
2.	Check out summary displays Card number of the borrower, Book ID that was checked out, Branch ID, date that the book was borrowed and the due date.

Feature #4: Quick check in button
Located at: “Check in” Tab page
Details:
The user can search for a book to check in by entering valid entry in any of the four fields( Book ID, Card Number, first name or  last name of the borrower) and perform a quick check in by simply clicking on the “Check In” button present near each row of the search result. 


Feature #5: Auto generated card number and its display
Located at: “Add Borrower” Tab page
Details:
Once the details of the new borrower is entered in the appropriate fields,
card number is auto generated as the next value of the largest existing card number 
and is displayed along with the newly added borrower details. 

