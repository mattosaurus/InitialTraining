# Console Application
1. Create a console application that can read 2 values from the command line and can add, subtract, multiply or divide them as required.

    This should take command line arguments like the following.

    ```
    -add 2 4
    6

    -subtract 9 5
    4

    -multiply 3 3
    9

    -divide 6 2
    3
    ```

2. Update your multiply and divide code to not use the * or / operators.
3. Break you maths methods out into a separate class and import that into your Program.cs file.
4. Implement an interface describing your methods and have your class inherit that.
5. Add a new class that implements your interface that does the work in SQL rather than within your application.
6. Add a new argument `-load` that takes a file path parameter. Your application will iterate through all rows in the file and perform the specified operations.
    ### operations.csv
    > operation,x,y\
    > multiply,9,7\
    > subtract,7,8\
    > subtract,87,12
7. If the `-load` file path is a directory loop through all files in the directory.
8. Add a new logging interface and implement a service that logs to SQL and a service that logs to a file.