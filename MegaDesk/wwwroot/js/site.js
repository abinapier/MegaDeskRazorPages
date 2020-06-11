// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function setDate() {
    let date = document.getElementById("date");
    let today = new Date();
    date.value = today.toISOString();
}

function calculateQuote() {
    let width = document.getElementById("width").value;
    let depth = document.getElementById("depth").value;
    let drawers = document.getElementById("drawer").value;
    let material = document.getElementById("material").value;
    let time = document.getElementById("time").value;
    if (width && depth && drawers > 0 && material && time) {
        //all values set

        let quoteTotal = 200;
        let surfaceArea = width * depth;
        if (surfaceArea > 1000) {
            quoteTotal += (surfaceArea - 1000);
        }
        quoteTotal += (drawers * 50);
        switch (material) {
            case "laminate":
                quoteTotal += 100;
                break;
            case "oak":
                quoteTotal += 200;
                break;
            case "rosewood":
                quoteTotal += 300;
                break;
            case "veneer":
                quoteTotal += 125;
                break;
            case "pine":
                quoteTotal += 50;
                break;
        }
        if (time == 3) {
            if (surfaceArea < 1000) {
                quoteTotal += 60;
            } else if (surfaceArea <= 2000) {
                quoteTotal += 70;
            } else {
                quoteTotal += 80;
            }

        } else if (time == 5) {
            if (surfaceArea < 1000) {
                quoteTotal += 40;
            } else if (surfaceArea <= 2000) {
                quoteTotal += 50;
            } else {
                quoteTotal += 60;
            }

        } else if (time == 7) {
            if (surfaceArea < 1000) {
                quoteTotal += 30;
            } else if (surfaceArea <= 2000) {
                quoteTotal += 35;
            } else {
                quoteTotal += 40;
            }
        }
        document.getElementById("quoteVal").value = quoteTotal;
        let submitBtn = document.getElementById("submit-btn");
        submitBtn.disabled = false;
        setDate();

    }
    
}

