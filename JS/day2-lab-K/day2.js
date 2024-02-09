//1- Create array that contain some tips about JavaScript (Array of 10 strings, each string is tip about JS), and show random tip for the user each time he opens the page "Tip of the day". 

// JavaScript tips array
var jsTips = [
    "Tip 1: Use 'const' and 'let' for variable declarations instead of 'var'.",
    "Tip 2: Always use semicolons at the end of statements to avoid unexpected behavior.",
    "Tip 3: Embrace arrow functions for concise and clear syntax.",
    "Tip 4: Understand and use '===', strict equality, to avoid type coercion.",
    "Tip 5: Take advantage of template literals for easy string interpolation.",
    "Tip 6: Familiarize yourself with array methods like map, filter, and reduce.",
    "Tip 7: Learn about closures and how they work in JavaScript.",
    "Tip 8: Use 'async/await' for handling asynchronous code instead of callbacks or promises.",
    "Tip 9: Be cautious with global variables to avoid unintended side effects.",
    "Tip 10: Explore the 'console' object for effective debugging."
    ];

// Function to get a random tip
    function getRandomTip() {
    var randomIndex = Math.floor(Math.random() * jsTips.length);
    return jsTips[randomIndex];
    console.log(getRandomTip());
    }


//2-Make a button that display the current date and time in local format on the page.

    function displayDateTime() {
    var currentDate = new Date();
    var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric', hour: 'numeric', minute: 'numeric', second: 'numeric', timeZoneName: 'short' };
    var localDateTime = currentDate.toLocaleDateString('ar-eg', options);

    document.getElementById('dateTime').innerText = `Current Date and Time: ${localDateTime}`;
    }

// 3- user to enter his Email, and use function strings 
    function validateEmail() {
    var userEmail = prompt("Please enter your email:");

    if (userEmail && userEmail.includes('@') && userEmail.indexOf('@') !== 0 && userEmail.indexOf('@') !== userEmail.length - 1) {
        alert("Email is valid!");
    } else {
        alert("Invalid email. Please make sure it contains '@' and is not at the beginning or end.");
    }
    }
    validateEmail();

//4- Prompt user to enter his Full Name and email address, and use regular expression 
        function validFullName(fullName){
            var regex = /^[a-zA-Z]+ [a-zA-Z]+$/;
            return regex.test(fullName);
        }

        var fullName = prompt("Please enter your full name:");
        if (validFullName(fullName)) {
            alert("Full name is valid!");
        } else {
            alert("Invalid full name. Please make sure it contains only letters and a space.");
        while (!validFullName(fullName)) {
            fullName = prompt("Please enter your full name:");
        };
    }  
    

    function validEmail(Email){
            var regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com\.eg|net\.eg|edu\.eg|org\.eg)$/;
            return regex.test(Email);
        }

        var Email = prompt("Please enter your Email:");
        if (validEmail(Email)) {
            alert("Email is valid!");
        } else {
            alert("Invalid Email. Please make sure it contains '@' and 'eg'.");
        while (!validEmail(Email)) {
            Email = prompt("Please enter your Email:");
        };
    }

    
//6- Create an array that hold the following students grades 

    var stdGrades = [60, 100,10,15,85];
    stdGrades.sort((a, b) =>b - a );
    console.log(stdGrades);

    var stdGradesPass = stdGrades.find((grade) =>grade <= 100);
    console.log(stdGradesPass);

    var stdGradesFail = stdGrades.filter((grade) => grade < 60 );
    console.log(stdGradesFail);

//7- Create an array of objects that hold student name along with his degree 

    var students = [
        { name: 'sarah', degree: 15},
        { name: 'ahmed', degree: 70},
        { name: 'marim', degree: 40},
        { name: 'ali', degree: 55},
        { name: 'karim', degree: 100},
    ]

    var studentDegreeHigh = students.find((student) =>student.degree === 100 && student.degree >= 90);
    console.log(studentDegreeHigh.name);

    var studentDegree = students.filter((student) =>student.degree > 60);

    studentDegree.forEach((student) => console.log(student.name));

    var studentDegreeName = studentDegree.map((student) =>student.name);
    console.log(studentDegreeName);

    students.push({ name: 'mena', degree: 95},
    { name: 'Esalm', degree: 80});
    console.log(students);


    students.pop();

    for (let student of students) {
    console.log(student.name + ': ' + student.degree);
    }

    students.sort();
    console.log(students);


    students.sort((a, b) => {
    var nameA = a.name.toLowerCase();
    var nameB = b.name.toLowerCase();

    return nameA < nameB ? -1 : (nameA > nameB ? 1 : 0);
    });

    students.splice(2, 0, { name: 'ziad', degree: 98}, { name: 'salma', degree: 69});

    console.log(students);
    

    students.splice(3, 1);

    console.log(students);


//8- Show prompt that ask user to enter his birth date and tell user to enter the date 
    
        function showAge() {
        
        var birthDate = prompt("Please enter your birth date (MM/DD/YYYY):");

        if (!isValidDateFormat(birthDate)) {
                alert("Invalid date format. Please enter the date in MM/DD/YYYY format.");
                return;
            }
        var birthDateArray = birthDate.split('/');
        var birthDateObject = new Date(birthDateArray[2], birthDateArray[0] - 1, birthDateArray[1]);
        var currentDate = new Date();
        var age = currentDate.getFullYear() - birthDateObject.getFullYear();
        var month = currentDate.getMonth() - birthDateObject.getMonth();
        var day = currentDate.getDate() - birthDateObject.getDate();

        if (month < 0 || (month === 0 && day < 0)) {
            age--;

            alert(`You are ${age} years old.`);
        } 

        function isValidDateFormat(dateString) {
                var dateRegex = /^\d{2}\/\d{2}\/\d{4}$/;
                return dateRegex.test(dateString);
            }
        }