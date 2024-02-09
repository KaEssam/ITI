//1- show alert for the user that say “Welcome to my site”, then show him prompt ask him to enter his name and write to the page  “ welcome + his name”.

alert("Welcome to my site");
var userName = prompt("Enter your name:");
document.write("Welcome, " + userName);


// Make a function in external JS file, that takes 2 parameters and return sum of them 
function sum(a, b) {
    return a + b;
}

//2- Sum Function
function calculateSum() {
    var num1 = parseFloat(prompt("Enter the first number:"));
    var num2 = parseFloat(prompt("Enter the second number:"));
    var result = sum(num1, num2);
    console.log("Result:", result);
}


//3- Make a function that takes today’s temperature as a parameter.

function checkTemperature(todayTemperature) {
    if (todayTemperature >= 30) {
        console.log("HOT");
    } else {
        console.log("Cold");
    }
}

//3- Make a function that takes today’s temperature as a parameter (use ternary conditional operator). 

function Temperature(todayTemperature) {
var result = (todayTemperature >= 30) ? "HOT" : "Cold";
console.log(result);
}

//4- Temperature and Actual feel temperature 
function checkTemperatureAndFeel(temperature, actualFeel) {
    if (temperature, actualFeel >= 25 && temperature, actualFeel <= 30) {
        console.log("Normal");
    } else if (temperature < 25 && actualFeel < 25) {
        console.log("Cold");
    } else if (temperature > 30 && actualFeel > 30) {
        console.log("Hot");
    } else {
        console.log("Ambiguous, can’t detect");
    }
}


//5- Make a function that takes Student faculty as a parameter

function checkFaculty(faculty) {
    switch (faculty) {
        case "FCI":
            console.log("You're eligible to Programming tracks");
            break;
        case "Engineering":
            console.log("You're eligible to Network and Embedded tracks");
            break;
        case "Commerce":
            console.log("You're eligible to ERP and Social media tracks");
            break;
        default:
            console.log("You're eligible to SW fundamentals track");
    }
}


//6- start and end number and print odd numbers between the given 2 numbers.

function printOddNumbers(start, end) {
    for (let i = start; i <= end; i++) {
        if (i % 2 !== 0) {
            console.log(i);
            }
        }
}

