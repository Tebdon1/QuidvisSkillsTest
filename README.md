# Quidvis Interview Skills Test

This is a simple skills test of dot.net, angular and SQL.  Please do not spend more than 2 hours on this test.

## SQL Database

1. Create a test database using a Database Server of your choice

2. There is a mySQL Script which creates the tables and example data. This can be simply modified if necessary for the database of your choice

3. Draw an Data Entity Diagram for the following tables
   - Clients
   - Properties
   - AuditCompanies
   - Audits
   - Floors
   - Areas
   - FireDoors

## REST APIs with .net and C#

Ideally using dapper rather the Entity Framewrite write an api to

1. get all Clients

2. get all Properties for a clientId

3. get all Audits for a propertyId

## Angluar Front-end

1. Client List
   - Display in a table 
      - ClientId
      - Name
      - View Properties action/button (Go to Properties List for selected client)

2. Properties List
   - Filter by client
   - Diplay in a table
      - Client Name
      - Property Name
      - Property Code
      - View Audits action/button (Go to Audits List for selected Property)


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

## Bootstrap

Please make the demostration look as professional as possible with a menu for the three options.


## Take more that 2 hours

Please do not take more than 2 hours to complete the test.







