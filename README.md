# Quidvis Skills Test: .NET, Angular, and SQL

This test is designed to evaluate your skills with .NET (C#), Angular, and SQL. We recommend spending no more than 3 hours on this. It’s okay if you don’t complete all tasks—just aim to demonstrate your ability.

## Instructions:

### Step 1: Clone the Repository

Use the following command to clone the test repository: `git clone https://github.com/ChrisEdwardsQVR/QuidvisSkillsTest.git`


### Step 2: SQL Database

1. Create a test database using a Database Server of your choice.

2. There is a [mySQL Script](data) that creates the tables and example data for this test. This can be easily modified for the database of your choice.

3. Draw a Data Entity Diagram (ERD) for the following tables:
   - Clients
   - Properties
   - AuditCompanies
   - Audits
   - Floors
   - Areas
   - FireDoors

### Step 3: REST APIs with .NET (C#)

Using Dapper (preferably) instead of Entity Framework, create a simple API to:

1. Get all Clients

2. Get all Properties for a clientId

3. Get all Audits for a propertyId

### Step 4: Angular Front-End

Using Angular, create a simple front-end that includes the following views:

1. Client List
   - Display in a table 
      - ClientId
      - Name
      - "View Properties" action/button (to navigate to the Properties List for the selected client)

2. Properties List
   - Filter by client.
   - Display in a table:
      - Client Name
      - Property Name
      - Property Code
      - "View Audits" action/button (to navigate to the Audits List for the selected property)

3. Audits List
   - Filter by property name
   - Display in a table
      - Audit Date (dd-mmm-yyyy)
      - Auditing Company
      - Client Name
      - Property Name
      - Property Code
      - Status
      - Assessment Type
      - Date Completed (dd-mmm-yyyy)

## Note:

1. Make the application look professional by using Bootstrap. Include a simple menu that allows navigation between the Client List, Properties List, and Audits List.

2. Please aim to complete the test in 3 hours. You don’t need to finish every task—just focus on demonstrating your skills.

3. Make sure your repository is public for the review.


## Once completed, please share the repository link with us.







