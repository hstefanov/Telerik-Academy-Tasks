//Problem 1. Increase array members
//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console

function solveProblemOne(){
    var arr = [],
        i;

    for(i = 0 ; i < 20 ; i+=1){
        arr[i] = i * 5;
    }

    document.getElementById('firstAnswer').innerHTML = arr.join(', ');
    console.log(arr.join(', '))
}

//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).

function solveProblemTwo(){
    var string1 = document.getElementById('string1').value,
        string2 = document.getElementById('string2').value,
        i,
        result = '';

    if(string1 !== '' && string2 !== ''){
        for(i = 0 ; i < Math.min(string1.length,string2.length); i+=1){
            if(string1[i] < string2[i]){
                result += string1 + ' comes before ' + string2;
                break;
            }
            if(string1[i] > string2[i]){
                result += string2 + ' comes before ' + string1;
                break;
            }
        }

        if(result === ''){
            if(string1.length < string2.length){
                result += string1 + ' comes before' + string2;
            } else if(string1.length > string2.length){
                result += string2 + ' comes before ' + string2;
            } else{
                result += string1 + ' equal ' + string2;
            }
        }
        document.getElementById('secondAnswer').innerHTML = result;
        console.log(result);
    } else{
        document.getElementById('secondAnswer').innerHTML = 'Please enter two strings';
    }

    document.getElementById('string1').value = '';
    document.getElementById('string2').value = '';
}

//Problem 3. Maximal sequence
//Write a script that finds the maximal sequence of equal elements in an array.

function solveProblemThree(){
    var input = document.getElementById('array3').value,
        validInput = validateInput(input),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        arr,
        i,
        len,
        maxSequence;

    if(validInput){
        arr = input.split(', ').map(Number);

        for(i = 1; i < arr.length; i+=1){
            if(arr[i] === arr[i-1]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    maxEndIndex = i;
                }
            } else {
                currentMax = 1;
            }
        }
        maxSequence = arr.slice(maxEndIndex - max + 1 , maxEndIndex + 1).join(', ');
        document.getElementById('asnwerThree').innerHTML = 'Maximal sequence of equal elements ' +  maxSequence;
        console.log(maxSequence);
    }
    else{
        document.getElementById('answerThree').innerHTML = 'Invalid input';
    }

    document.getElementById('array3').value = '';
}

//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.

function solveProblemFour(){
    var input = document.getElementById('array4').value,
        validInput = validateInput(input),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        arr,
        i,
        maxSequence;

    if(validInput){
        arr = input.split(', ').map(Number);
        for(i = 1; i < arr.length ; i+=1){
            if(arr[i] > arr[i - 1]){
                currentMax+=1;
                if(currentMax > max){
                    max = currentMax;
                    maxEndIndex = i;
                }
            } else{
                currentMax = 1;
            }
        }

        maxSequence = arr.slice(maxEndIndex - max + 1, maxEndIndex + 1).join(', ');
        document.getElementById('asnwerFour').innerHTML = 'Maximal increasing sequence : ' + maxSequence;
        console.log(maxSequence);
    }else{
        document.getElementById('asnwerFour').innerHTML = 'Invalid input';
    }
}

//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

function solveProblemFive(){
    var input = document.getElementById('array5').value;

    var arr = input.split(', ').map(Number);
    for(var i = 0; i < arr.length - 1; i+=1){
        for(var j = i + 1 ; j < arr.length; j+=1){
            if(arr[i] > arr[j]){
                swap(arr,i,j);
            }
        }
    }

    document.getElementById('answerFive').innerHTML = arr.join(', ');
}

function swap(items,firstIndex,secondIndex){
    var temp = items[firstIndex];
    items[firstIndex] = items[secondIndex];
    items[secondIndex] = temp;
}


//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.

function solveProblemSix(){
    var input = document.getElementById('array6').value,
        map = {};

    var arr = input.split(', ').map(Number);
    var maxEl = arr[0], maxCount = 1,i;
    for(i = 0 ; i < arr.length ; i+=1){
        var tmpEl = arr[i];
        if(map[tmpEl] == null){
            map[tmpEl] = 1;
        }else{
            map[tmpEl]+=1;
        }

        if(map[tmpEl] > maxCount){
            maxEl = tmpEl;
            maxCount = map[tmpEl];
        }
    }
    document.getElementById('answerSix').innerHTML = maxEl;
}

function solveProblemSeven(){
    var input = document.getElementById('array7').value,
        searchElement = document.getElementById('number7').value;


    var arr = input.split(', ').map(Number);
    arr.sort(function (a,b){
        return a - b;
    });

    searchElement *= 1;
    var indexOf = binarySearch(arr,searchElement);

    document.getElementById('answerSeven').innerHTML = indexOf;
    console.log(indexOf);
}

function binarySearch(arr,searchElement){
    var minIndex = 0,
        maxIndex = arr.length - 1,
        currentIndex,
        currentElement;

    while(minIndex <= maxIndex){
        currentIndex = (minIndex + maxIndex) / 2 | 0; // instead of Math.floor
        currentElement = arr[currentIndex];
        if(currentElement < searchElement){
            minIndex = currentIndex + 1;
        } else if(currentElement > searchElement){
            maxIndex = currentIndex - 1;
        } else{
            return currentIndex;
        }
    }
}

function validateInput(input){
    var validInput = true;
    if(input === ''){
        validInput = false;
    } else{
        var arr = input.split(', ').map(Number);
        for(var i = 0; i < arr.length; i+=1){
            if(isNaN(arr[i])){
                validInput = false;
                break;
            }
        }
    }
    return validInput;
}