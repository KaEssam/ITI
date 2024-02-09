
//1- Create a new page that has a textbox, and alert the code of key pressed on a textbox
        var input = document.getElementById('text');

        text.addEventListener("keydown", (e) => {
            if (!e.repeat) {
                alert(e.keyCode);
            } else {
                alert(e.keyCode);
            }
        });

        text.addEventListener("mousedown", (e) => {
            if (!e.button) {
                alert(e.button);
            } else {
                alert(e.button);
            }
        });

//2- Make a button (Start clock), that showing alert saying “Clock Started” and displays clock with current time in local format 

        var button = document.getElementById('button');
        var clockDisplay = document.getElementById('clock');
        var stopButton = document.getElementById('button-stop');
        var t;

        button.addEventListener("click", () => {
            alert("Clock Started");
            t=setInterval(() => {
                var currentDate = new Date();
                var options = {hour: 'numeric', minute: 'numeric', second: 'numeric'};
                var localDateTime = currentDate.toLocaleDateString('ar-eg', options);
                clockDisplay.textContent = localDateTime;
            }, 1000);

        stopButton.addEventListener("click", () => {
            alert("Clock Stopped");
            clearInterval(t);
        });
        });

//3- Create a page that contains 3 images, and use JavaScript

        var imageContainer = document.getElementById('imageContainer');
        var clickCount = document.getElementById('clickCount');
        var img1 = document.getElementById('img-1');
        var img2 = document.getElementById('img-2');
        var img3 = document.getElementById('img-3');

        imageContainer.addEventListener("click", (e) => {
            if (e.target.id == "img-1" || e.target.id == "img-2" || e.target.id == "img-3") {
        clickCount.textContent++;
            }
        });

        clickCount.addEventListener("click", (e) => {
            clickCount.removeEventListener("click", clickCount);
            clickCount.addEventListener("click", (e) => {
                console.log("click mouse");
            });
        });

        console.log("set timeout removed");

        setTimeout(() => {
            alert(`Game Over, your score is ${clickCount.textContent}`)
        }, 3000);



//4- Create a login form that redirect to another page when user submit the form
        var username = document.getElementById('username');
        var password = document.getElementById('password');
        var submit = document.getElementById('login');
        var loginForm = document.getElementById('login-form');

        

        function validateUsername() {
            var regex = /^[a-zA-Z0-9]+$/;
            return regex.test(username.value);
        }

        function validatePassword() {
            var regex = /^[a-zA-Z0-9]+$/;
            return regex.test(password.value);
        }
        submit.addEventListener("click", () => {
            if (validateUsername() && validatePassword()) {
                alert("Login Successful");

                var newWindow = window.open("");
                var welcomeMessage = document.createElement('h1');
                welcomeMessage.textContent = "Welcome, " + username.value;
                newWindow.document.body.appendChild(welcomeMessage);
            } else {
                alert("Login Failed");
            }
        });


//5- Make a link that on its onClick event opens new advertising window after 3 seconds

        var link = document.createElement('a');
        link.textContent = "DON'T CLICK ME";
        link.setAttribute('href', '#');
        document.body.appendChild(link);

        link.addEventListener("click", () => {
            setTimeout(() => {
                var newWindow = window.open("");
                var adMessage = document.createElement('h1');
                adMessage.textContent = "hahahaha idiot";
                newWindow.document.body.appendChild(adMessage);
            }, 3000);
        });

//6-On registration form you make I Day.2, make a check box and label next to it 

        var termsChecked = document.getElementById('termsChecked');
        var loginButton = document.getElementById('login');

        loginButton.addEventListener("click", () => {
            if (termsChecked.checked) {
                alert("Login Successful agree");
            } else {
                alert("Please agree to the terms and conditions");
            }
        });

//7- make the textbox of first name that accepts alphabetic characters only and don't accept numbers 

// alphabetic key code https://www.cambiaresearch.com/articles/15/javascript-char-codes-key-codes

        function validateAlphabetic(event) {
            var keyCode = event.keyCode;
            if ((keyCode >= 65 && keyCode <= 90) || (keyCode >= 8 && keyCode <= 46))  {
                console.log("Valid name");
            } else {
                event.preventDefault();
            }
        }



        
