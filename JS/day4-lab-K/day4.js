
//1- Make a registration form 

    function ChangeColor(inputElem){
        inputElem.style.backgroundColor="lightgrey"
        }
        function ValidateName(username){
            if(username.value.length <3){
                username.focus();
                username.select();
                document.getElementById("username").innerHTML="<b style='color:red'>Name must be more than 3 char</b>"
            }
            else{
                document.getElementById("username").innerHTML="<b style='color:green'>Valid </b>"
                

            }
        }
        
                var password = document.getElementById("password").value;
            var repeatPassword = document.getElementById("repeatPassword").value;
        function validatePassword(password){
            if(password.value.length <8){
                document.getElementById("password").innerHTML="<b style='color:red'>Password must be more than 8 char</b>"
            }
            else{
                document.getElementById("password").innerHTML="<b style='color:green'>Valid </b>"
            }
            if (password==""){
                document.getElementById("password").innerHTML="<b style='color:red'>Fill the password please!</b>"
            }
            else{
                return false;
                
            }
        }

        function validateRepeatPassword(RepeatPassword){
            if(password.value.length <8){
                document.getElementById("password").innerHTML="<b style='color:red'>Password must be more than 8 char</b>"
            }
            else{
                document.getElementById("password").innerHTML="<b style='color:green'>Valid </b>"
            }

            if (RepeatPassword==""){
                document.getElementById("password").innerHTML="<b style='color:red'>Fill the password please!</b>"
            }
            else{
                return false;
                
            }
        }
    
        function matchPassword(){
            if(password != repeatPassword){
                document.getElementById("repeatPasswordMessage").innerHTML="<b style='color:red'>Password not match</b>"
            }
            else{
                document.getElementById("repeatPasswordMessage").innerHTML="<b style='color:green'>Password match</b>"
            }
        }

        function validateEmail(email){
            var email = document.getElementById("email").value;
            var emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
            if(emailRegex.test(email)){
                document.getElementById("emailMessage").innerHTML="<b style='color:green'>Valid Email</b>"
            }
            else{
                document.getElementById("emailMessage").innerHTML="<b style='color:red'>Invalid Email</b>"
            }
        }

            document.querySelector('.registration-form').addEventListener('submit', function(event) {
                if (!validateName(this.elements.username) || !validatePassword() || !validateRepeatPassword() || !matchPassword()) {
        event.preventDefault();
                } else {
        console.log('Form submitted successfully!');
                }
            });
                



    //  2- Make a photo gallery with buttons 

    document.addEventListener('DOMContentLoaded', function () {

        var gallery = document.getElementById('gallery');
        var images = ['/day4-lab-K/img/img-1.jpeg', '/day4-lab-K/img/img-2.jpg', '/day4-lab-K/img/img-3.jpeg']; 

        
        var playBtn = document.getElementById('play');
        var stopBtn = document.getElementById('stop');
        var nextBtn = document.getElementById('next');
        var prevBtn = document.getElementById('prev');

    
        var currentIndex = 0;
        var slideshowInterval;

        
        function createAndAppendImage() {
            var img = document.createElement('img');
            img.setAttribute('src', images[currentIndex]);
            gallery.innerHTML = ''; 
            gallery.appendChild(img);
        }

        
        gallery.addEventListener('mouseover', function () {
            gallery.querySelector('img').style.opacity = 0.3;
        });

        
        gallery.addEventListener('mouseout', function () {
            gallery.querySelector('img').style.opacity = 1;
        });

        
        playBtn.addEventListener('click', function () {
            slideshowInterval = setInterval(function () {
                currentIndex = (currentIndex + 1) % images.length;
                createAndAppendImage();
            }, 500);
        });

        
        stopBtn.addEventListener('click', function () {
            clearInterval(slideshowInterval);
        });

        
        nextBtn.addEventListener('click', function () {
            currentIndex = (currentIndex + 1) % images.length;
            createAndAppendImage();
        });

        
        prevBtn.addEventListener('click', function () {
            currentIndex = (currentIndex - 1 + images.length) % images.length;
            createAndAppendImage();
        });

        
        createAndAppendImage();

        
        alert('Number of child nodes in the gallery: ' + gallery.childNodes.length);

        
        setTimeout(function () {
            gallery.removeChild(gallery.querySelector('img'));
        }, 3000); 
    });
