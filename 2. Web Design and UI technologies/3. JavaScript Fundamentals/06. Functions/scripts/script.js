//Problem 1. English digit
//Write a function that returns the last digit of given integer as an English word.

function problem1(){
    var input = document.getElementById('number1').value,
        result,
        lastNum;

    if(input !== '' && !isNaN(input) && input % 1 === 0 ){
        input *= 1;
        lastNum = input % 10;
        switch (lastNum){
            case 0:
                result = 'Zero';
                break;
            case 1:
                result = 'One';
                break;
            case 2:
                result = 'Two'
                break;
            case 3:
                result = 'Three';
                break;
            case 4:
                result = 'Four';
                break;
            case 5:
                result = 'Five';
                break;
            case 6:
                result = 'Six';
                break;
            case 7:
                result = 'Seven';
                break;
            case 8:
                result = 'Eight';
                break;
            case 9:
                result = 'Nine';
                break;
        }
        document.getElementById('asnwerOne').innerHTML = result;
        console.log(result);
    }else {
        document.getElementById('asnwerOne').innerHTML = 'Invalid input';
    }

    document.getElementById('number1').value = '';
}


//Problem 2. Reverse number
//Write a function that reverses the digits of given decimal number.

function problem2(){
    var input = document.getElementById('number2').value,
        result = '',
        i,
        len;
    console.log(input);
    if(input !== '' && !isNaN(input)){
        input *= 1;
        if(input < 0 ){
            result += '-';
        }
        input = (-input).toString();
        console.log(input);
        len = input.length - 1;
        for(i = len; i >= 0 ; i-=1 ){
            result += input[i];
        }

        document.getElementById('answerTwo').innerHTML = result;
        console.log(result);
    } else{
        document.getElementById('answerTwo').innerHTML = 'Invalid input';
    }

    document.getElementById('number2').value = '';
}

//Problem 3. Occurrences of word
//Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.

function problem3(){
    var check = document.getElementById('check').checked,
        search = document.getElementById('word').value,
        text = document.getElementsByTagName('p')[0].innerHTML;

    console.log(text)
    console.log(check);
    if(search !== ''){
        if(check){
            wordOccurences(text,search);
        }else{
            wordOccurences(text,search,check);
        }
    }else{
        document.getElementById('answerThree').innerHTML = 'Invalid input';
    }
}

function wordOccurences(string,substring,caseSensitive){
    var occurences;

    switch (arguments.length) {
        case 2:
            occurences = searchWord(string, substring);
            break;
        case 3:
            occurences = searchWord(string, substring, caseSensitive);
            break;
    }
    document.getElementById('answerThree').innerHTML = 'Occurences of the word : ' + substring + '-' + occurences;
}

function searchWord(string,substring,caseSensitive){
    var count = 0,
        pos = 0,
        step;

    string = string || '';
    substrint = substring || '';
    sensitive = caseSensitive || false;


    if(caseSensitive){
        string = string.toLowerCase();
        substring = substring.toLowerCase();
    }

    step = substring.length;
    while(true){
        pos = string.indexOf(substring,pos);
        if(pos >= 0){
            count+=1;
            pos+=step;
        }else{
            break;
        }
    }
    return count;
}

//Problem 4. Number of elements
//Write a function to count the number of div elements on the web page

function problem4(){
    var divCount = document.getElementsByTagName('div').length;
    document.getElementById('answerFour').innerHTML = 'Count of divs elements : ' + divCount;
}

//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

function problem5(){
    var input = document.getElementById('array1').value || [],
        arr,
        i,
        result,
        number = document.getElementById('number5').value;
    if(number !== '' && !isNaN(number)){
        arr = input.split(', ').map(Number);
        number *= 1;
        result = countNumber(number,arr);
        document.getElementById('answerFive').innerHTML = 'Number ' + number + ' appears ' + result + ' times in the array';
        console.log(result);
    } else{
        document.getElementById('answerFive').innerHTML = 'Invalid input';
    }
}

function countNumber(number,arr){
    var counter = 0;
    for(var i in arr){
        if(arr[i] == number){
            counter+=1;
        }
    }

    return counter;
}

function test(){
    var arr = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5];
    var test1 = countNumber(1,arr),
        test2 = countNumber(2,arr),
        test3 = countNumber(3,arr),
        test4 = countNumber(4,arr);

    if(test1 == 1){
        document.getElementById('test5').innerHTML += 'test1 : ok\t,';
    }
    if(test2 == 2){
        document.getElementById('test5').innerHTML +=  'test2 : ok\t,';
    }
    if(test3 == 3){
        document.getElementById('test5').innerHTML += 'test3 : ok\t,';
    }
    if(test4 == 4){
        document.getElementById('test5').innerHTML += 'test4 : ok\t';
    }
}

//Problem 6. Larger than neighbours
//Write a function that checks if the element at given position in given array of integers is
//bigger than its two neighbours (when such exist).

function problem6(){
    var input = document.getElementById('array2').value || [],
        arr,
        i,
        result,
        index = document.getElementById('number6').value;

    if(index !== '' && !isNaN(index) && (index % 1 === 0)){
        arr = input.split(', ').map(Number);
        index *= 1;
        if(index >= 0 && index < arr.length){
            if(index > 0 && index < arr.length - 1){
                result = checkNeighbour(index,arr);
                if(result) {
                    result = 'The element is bigger than it\'s neightbour';
                }else{
                    result =  'The element is NOT bigger than it\'s neightbour';
                }
            } else{
                result = 'This element has only one neighbour';
            }
        } else{
            result = 'Index must be > 0 and < ' + arr.length -1;
        }
        document.getElementById('answerSix').innerHTML = result;
    }else{
        document.getElementById('answerSix').innerHTML = 'Invalid input';
    }
}

function checkNeighbour(index,arr){
    if((arr[index] > arr[index - 1]) && (arr[index] > arr[index +1])){
        return true;
    }else{
        return false;
    }
}

function problem7(){
    var input = document.getElementById('array3').value || [],
        arr,
        i,
        result,
        len;

    arr = input.split(', ').map(Number);
    len = arr.length;
    for(i = 0 ; i < len ; i+=1){
        if(checkNeighbour(i,arr)){
            result = i;
            break;
        }
    }
    document.getElementById('answerSeven').innerHTML = 'Index of first element bigger than' +
        'it\'s neighbours (-1 if none): ' + result;
    console.log('Problem 7: Index of first element bigger than' +
        'it\'s neighbours (-1 if none): ' + result);
}