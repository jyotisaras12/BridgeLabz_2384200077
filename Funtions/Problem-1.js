const readline = require("readline-sync");

// Function to convert Celsius to Fahrenheit
function celsiusToFahrenheit(degC) {
    if (degC < 0 || degC > 100) {
        console.log("Enter a value between 0°C and 100°C.");
        return;
    }
    let degF = (degC * 9/5) + 32;
    console.log(`${degC}°C = ${degF}°F`);
}

// Function to convert Fahrenheit tp Celsius
function fahrenheitToCelsius(degF) {
    if (degF < 32 || degF > 212) {
        console.log("Enter a value between 32°F and 212°F.");
        return;
    }
    let degC = (degF - 32) * 5/9;
    console.log(`${degF}°F = ${degC.toFixed(2)}°C`);
}

// main function
function main() {
    console.log("Choose conversion option: \n1. Celsius to Fahrenheit \n2. Fahrenheit to Celsius");
    let choice = parseInt(readline.question("Enter choice (1 or 2): "));

    switch (choice) {
        case 1:
            let degC = parseFloat(readline.question("Enter temperature in Celsius: "));
            celsiusToFahrenheit(degC);
            break;
        case 2:
            let degF = parseFloat(readline.question("Enter temperature in Fahrenheit: "));
            fahrenheitToCelsius(degF);
            break;
        default:
            console.log("Invalid choice!");
    }
}

// Call main function to start the program
main();
