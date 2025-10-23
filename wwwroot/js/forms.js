// Form submission handling for His Vision Home Health website

// Captcha functionality
async function loadCaptcha(questionElementId, answerElementId, expectedAnswerElementId) {
    try {
        const response = await fetch('/Forms/GetCaptcha');
        const data = await response.json();
        
        document.getElementById(questionElementId).textContent = data.question;
        document.getElementById(expectedAnswerElementId).value = data.answer;
        document.getElementById(answerElementId).value = '';
    } catch (error) {
        console.error('Error loading captcha:', error);
    }
}

// Referral Form Handler
document.addEventListener('DOMContentLoaded', function() {
    const referralForm = document.getElementById('referralForm');
    if (referralForm) {
        referralForm.addEventListener('submit', async function(e) {
            e.preventDefault();
            
            const formData = new FormData(this);
            
            // Add captcha data
            const captchaAnswer = document.getElementById('referralCaptchaAnswer').value;
            const captchaExpectedAnswer = document.getElementById('referralCaptchaExpectedAnswer').value;
            formData.append('captchaAnswer', captchaAnswer);
            formData.append('captchaExpectedAnswer', captchaExpectedAnswer);
            
            const submitButton = this.querySelector('button[type="submit"]');
            const originalText = submitButton.innerHTML;
            
            // Show loading state
            submitButton.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Submitting...';
            submitButton.disabled = true;
            
            try {
                const response = await fetch('/Forms/SubmitReferral', {
                    method: 'POST',
                    body: formData
                });
                
                const result = await response.json();
                
                if (result.success) {
                    // Show success message
                    const successAlert = document.createElement('div');
                    successAlert.className = 'alert alert-success alert-dismissible fade show';
                    successAlert.innerHTML = `
                        <strong>Success!</strong> ${result.message}
                        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                    `;
                    
                    this.parentNode.insertBefore(successAlert, this);
                    this.reset();
                } else {
                    // Show error message
                    const errorAlert = document.createElement('div');
                    errorAlert.className = 'alert alert-danger alert-dismissible fade show';
                    errorAlert.innerHTML = `
                        <strong>Error!</strong> ${result.message}
                        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                    `;
                    
                    this.parentNode.insertBefore(errorAlert, this);
                }
            } catch (error) {
                // Show error message
                const errorAlert = document.createElement('div');
                errorAlert.className = 'alert alert-danger alert-dismissible fade show';
                errorAlert.innerHTML = `
                    <strong>Error!</strong> An unexpected error occurred. Please try again.
                    <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                `;
                
                this.parentNode.insertBefore(errorAlert, this);
            } finally {
                // Reset button state
                submitButton.innerHTML = originalText;
                submitButton.disabled = false;
            }
        });
    }

    // Career Application Form Handler
    const careerForm = document.getElementById('careerForm');
    if (careerForm) {
        careerForm.addEventListener('submit', async function(e) {
            e.preventDefault();
            
            const formData = new FormData(this);
            
            // Add captcha data
            const captchaAnswer = document.getElementById('careerCaptchaAnswer').value;
            const captchaExpectedAnswer = document.getElementById('careerCaptchaExpectedAnswer').value;
            formData.append('captchaAnswer', captchaAnswer);
            formData.append('captchaExpectedAnswer', captchaExpectedAnswer);
            
            const submitButton = this.querySelector('button[type="submit"]');
            const originalText = submitButton.innerHTML;
            
            // Show loading state
            submitButton.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Submitting...';
            submitButton.disabled = true;
            
            try {
                const response = await fetch('/Forms/SubmitCareerApplication', {
                    method: 'POST',
                    body: formData
                });
                
                const result = await response.json();
                
                if (result.success) {
                    // Show success message
                    const successAlert = document.createElement('div');
                    successAlert.className = 'alert alert-success alert-dismissible fade show';
                    successAlert.innerHTML = `
                        <strong>Success!</strong> ${result.message}
                        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                    `;
                    
                    this.parentNode.insertBefore(successAlert, this);
                    this.reset();
                } else {
                    // Show error message
                    const errorAlert = document.createElement('div');
                    errorAlert.className = 'alert alert-danger alert-dismissible fade show';
                    errorAlert.innerHTML = `
                        <strong>Error!</strong> ${result.message}
                        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                    `;
                    
                    this.parentNode.insertBefore(errorAlert, this);
                }
            } catch (error) {
                // Show error message
                const errorAlert = document.createElement('div');
                errorAlert.className = 'alert alert-danger alert-dismissible fade show';
                errorAlert.innerHTML = `
                    <strong>Error!</strong> An unexpected error occurred. Please try again.
                    <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                `;
                
                this.parentNode.insertBefore(errorAlert, this);
            } finally {
                // Reset button state
                submitButton.innerHTML = originalText;
                submitButton.disabled = false;
            }
        });
    }

    // Contact Form Handler
    const contactForm = document.getElementById('contactForm');
    if (contactForm) {
        contactForm.addEventListener('submit', async function(e) {
            e.preventDefault();
            
            const formData = new FormData(this);
            
            // Add captcha data
            const captchaAnswer = document.getElementById('contactCaptchaAnswer').value;
            const captchaExpectedAnswer = document.getElementById('contactCaptchaExpectedAnswer').value;
            formData.append('captchaAnswer', captchaAnswer);
            formData.append('captchaExpectedAnswer', captchaExpectedAnswer);
            
            const submitButton = this.querySelector('button[type="submit"]');
            const originalText = submitButton.innerHTML;
            
            // Show loading state
            submitButton.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Sending...';
            submitButton.disabled = true;
            
            try {
                const response = await fetch('/Forms/SubmitContactMessage', {
                    method: 'POST',
                    body: formData
                });
                
                const result = await response.json();
                
                if (result.success) {
                    // Show success message
                    const successAlert = document.createElement('div');
                    successAlert.className = 'alert alert-success alert-dismissible fade show';
                    successAlert.innerHTML = `
                        <strong>Success!</strong> ${result.message}
                        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                    `;
                    
                    this.parentNode.insertBefore(successAlert, this);
                    this.reset();
                } else {
                    // Show error message
                    const errorAlert = document.createElement('div');
                    errorAlert.className = 'alert alert-danger alert-dismissible fade show';
                    errorAlert.innerHTML = `
                        <strong>Error!</strong> ${result.message}
                        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                    `;
                    
                    this.parentNode.insertBefore(errorAlert, this);
                }
            } catch (error) {
                // Show error message
                const errorAlert = document.createElement('div');
                errorAlert.className = 'alert alert-danger alert-dismissible fade show';
                errorAlert.innerHTML = `
                    <strong>Error!</strong> An unexpected error occurred. Please try again.
                    <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                `;
                
                this.parentNode.insertBefore(errorAlert, this);
            } finally {
                // Reset button state
                submitButton.innerHTML = originalText;
                submitButton.disabled = false;
            }
        });
    }

    // Initialize captcha for all forms and set up refresh buttons
    initializeCaptcha();
});

function initializeCaptcha() {
    // Load initial captcha for each form
    loadCaptcha('referralCaptchaQuestion', 'referralCaptchaAnswer', 'referralCaptchaExpectedAnswer');
    loadCaptcha('careerCaptchaQuestion', 'careerCaptchaAnswer', 'careerCaptchaExpectedAnswer');
    loadCaptcha('contactCaptchaQuestion', 'contactCaptchaAnswer', 'contactCaptchaExpectedAnswer');

    // Set up refresh button handlers
    const referralRefreshBtn = document.getElementById('referralRefreshCaptcha');
    if (referralRefreshBtn) {
        referralRefreshBtn.addEventListener('click', function() {
            loadCaptcha('referralCaptchaQuestion', 'referralCaptchaAnswer', 'referralCaptchaExpectedAnswer');
        });
    }

    const careerRefreshBtn = document.getElementById('careerRefreshCaptcha');
    if (careerRefreshBtn) {
        careerRefreshBtn.addEventListener('click', function() {
            loadCaptcha('careerCaptchaQuestion', 'careerCaptchaAnswer', 'careerCaptchaExpectedAnswer');
        });
    }

    const contactRefreshBtn = document.getElementById('contactRefreshCaptcha');
    if (contactRefreshBtn) {
        contactRefreshBtn.addEventListener('click', function() {
            loadCaptcha('contactCaptchaQuestion', 'contactCaptchaAnswer', 'contactCaptchaExpectedAnswer');
        });
    }
}

// Add captcha refresh after successful form submissions
document.addEventListener('DOMContentLoaded', function() {
    // Override the form reset to also refresh captcha
    const originalReset = HTMLFormElement.prototype.reset;
    HTMLFormElement.prototype.reset = function() {
        originalReset.call(this);
        
        // Refresh captcha based on form ID
        if (this.id === 'referralForm') {
            loadCaptcha('referralCaptchaQuestion', 'referralCaptchaAnswer', 'referralCaptchaExpectedAnswer');
        } else if (this.id === 'careerForm') {
            loadCaptcha('careerCaptchaQuestion', 'careerCaptchaAnswer', 'careerCaptchaExpectedAnswer');
        } else if (this.id === 'contactForm') {
            loadCaptcha('contactCaptchaQuestion', 'contactCaptchaAnswer', 'contactCaptchaExpectedAnswer');
        }
    };
});


