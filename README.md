LibraryGUI
==========

Final version of Library application source files

The data base connection parameters need to be modified to appropriate value
to run the application

Description of the GUI and user manual:

1. Tab 1 - Determining Book Availability

	*  Users can search for a book, given any combination of book_id, title, and/or author_name. Supports substring matching. Following are displayed:
	* 
		* book_id
		* branch_id
		* Both Total number and Available number of book copies at each branch. 
		
2. Tab 2  Book Loans:
Checking Out Books

	*     Function is to check out a book, given the combination of BOOK_COPIES(book_id, branch_id) and BORROWER(Card_no), (a new tuple in BOOK_LOANS). The date_out is today’s date. The due_date is 14 days after the date_out.
	* 	* Each BORROWER is permitted a maximum of 3 BOOK_LOANS. If a BORROWER already has 3 BOOK_LOANS, then the checkout (i.e. create new BOOK_LOANStuple) should fail and returns an error message.
		* If the number of BOOK_LOANS for a given book at a branch already equals the No_of_copies (i.e. There are no more book copies available at your library_branch), then the checkout fails and returns an error message.

3. Tab 3 - Check in:
Checking In Books

	* Check in a book. Locates BOOK_LOANS tuples by searching on any of book_id, Card_no, and/or any part of BORROWER name. Once located, provides a way of selecting one of potentially multiple results and a button (or menu item) to check in (i.e. delete that BOOK_LOANS tuple).

4. Tab 4 - Borrowers

	*    Users can create new borrowers in the system. 
	* 
		* All name and address attributes are required to create a new account (i.e. not null).
		* Borrowers are allowed to possess exactly one library card. If a new borrower is attempted withe same fname, lname, and address, then operation will be rejected and an error message is returned.




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

