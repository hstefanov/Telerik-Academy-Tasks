//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function Point(x, y) {
    return {
        'x': x,
        'y': y
    };
}

function Line(point1, point2) {
    return {
        'p1': point1,
        'p2': point2,
        'length': calculateDistance(point1, point2)
    };
}

function problem1(){
    var x1 = document.getElementById('x1').value,
        y1 = document.getElementById('y1').value,
        x2 = document.getElementById('x2').value,
        y2 = document.getElementById('y2').value,
        line1,
        x3 = document.getElementById('x3').value,
        y3 = document.getElementById('y3').value,
        x4 = document.getElementById('x4').value,
        y4 = document.getElementById('y4').value,
        line2,
        x5 = document.getElementById('x5').value,
        y5 = document.getElementById('y5').value,
        x6 = document.getElementById('x6').value,
        y6 = document.getElementById('y6').value,
        line3,
        i;

    for (i = 1; i <= 6; i += 1) {
        if (isNaN(document.getElementById('x' + i).value) ||
            document.getElementById('x' + i).value === '' ||
            isNaN(document.getElementById('y' + i).value) ||
            document.getElementById('y' + i).value === '') {
            document.getElementById('pr1answer').innerHTML = 'Invalid input';
            return;
        }
    }

    p1 = Point(x1, y1);
    p2 = Point(x2, y2);
    p3 = Point(x3, y3);
    p4 = Point(x4, y4);
    p5 = Point(x5, y5);
    p6 = Point(x6, y6);

    if (calculateDistance(p1, p2)) {
        segment1 = Line(p1, p2);
        document.getElementById('segment1').innerHTML =
            'Segment 1: p1(' + p1.x + ', ' + p1.y + '), p2(' + p2.x + ', ' + p2.y + ') length: ' + segment1.length;
        console.log('Segment 1: p1(' + p1.x + ', ' + p1.y + '), p2(' + p2.x + ', ' + p2.y + ') length: ' + segment1.length);
    } else {
        document.getElementById('pr1answer').innerHTML = 'Points p1 and p2 cannot create a segment';
        document.getElementById('segment1').innerHTML = 'Points p1 and p2 cannot create a segment';
        console.log('Points p1 and p2 cannot create a segment');
        return;
    }
    if (calculateDistance(p3, p4)) {
        segment2 = Line(p3, p4);
        document.getElementById('segment2').innerHTML =
            'Segment 2: p3(' + p3.x + ', ' + p3.y + '), p4(' + p4.x + ', ' + p4.y + ') length: ' + segment2.length;
        console.log('Segment 2: p3(' + p3.x + ', ' + p3.y + '), p4(' + p4.x + ', ' + p4.y + ') length: ' + segment2.length);
    } else {
        document.Line('pr1answer').innerHTML = 'Points p3 and p4 cannot create a segment';
        document.getElementById('segment2').innerHTML = 'Points p3 and p4 cannot create a segment';
        console.log('Points p3 and p4 cannot create a segment');
        return;
    }
    if (calculateDistance(p5, p6)) {
        segment3 = Line(p5, p6);
        document.getElementById('segment3').innerHTML =
            'Segment 3: p5(' + p5.x + ', ' + p5.y + '), p6(' + p6.x + ', ' + p6.y + ') length: ' + segment3.length;
        console.log('Segment 3: p5(' + p5.x + ', ' + p5.y + '), p6(' + p6.x + ', ' + p6.y + ') length: ' + segment3.length);
    } else {
        document.getElementById('pr1answer').innerHTML = 'Points p5 and p6 cannot create a segment';
        document.getElementById('segment3').innerHTML = 'Points p5 and p6 cannot create a segment';
        console.log('Points p5 and p6 cannot create a segment');
        return;
    }
    document.getElementById('pr1answer').innerHTML =
        'Segments 1, 2, and 3 can form a triangle? --> ' + canFormTriangle(segment1, segment2, segment3);
    console.log('Segments 1, 2, and 3 can form a triangle? --> ' + canFormTriangle(segment1, segment2, segment3));
}


function calculateDistance(point1, point2) {
    return Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) +
        (point1.y - point2.y) * (point1.y - point2.y));
}


function canFormTriangle(sideA, sideB, sideC) {
    if ((sideA.length + sideB.length > sideC.length) &&
        (sideA.length + sideC.length > sideB.length) &&
        (sideB.length + sideC.length > sideA.length)) {
        return true;
    } else {
        return false;
    }
}


//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.


function problem2(){

    if(!Array.prototype.remove){
        Array.prototype.remove = function(val,all){
            var i,
                removedItems = [];
            if(all){
                for(i = this.length - 1; i--;){
                    if(this[i] === val){
                        removedItems.push(this.splice(i,1));
                    }
                }
            } else{
                i = this.indexOf(val);
                if(i > -1){
                    removedItems = this.splice(i,1);
                }
            }
            return this;
        };
    }

    var input = document.getElementById('arr1').value,
        element = document.getElementById('element1').value,
        result,
        i,
        arr = input.split(','),
        len;

    for (i = 0, len = arr.length; i < len; i += 1) {
        if (!isNaN(arr[i])) {
            arr[i] *= 1;
        }
    }
    result = 'Initial array: ' + arr + '; array after removing ' +
        element + ': ';

    if (!isNaN(element)) {
        result = arr.remove(element * 1,true);
    } else {
        result = arr.remove(element);
    }

    document.getElementById('pr2answer').innerHTML = result;
    console.log('Problem 2: ' + result);
}

//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

function problem3() {
    var obj = {
            stringProperty: 'this is a string',
            numberProperty: 5,
            arrayProperty: [1, 2, 3, 4, 5],
            objectProperty: {
                a: 5,
                b: 7,
                c: [1, 2, 3]
            }
        },
        copy = createDeepCopy(obj),
        result = '',
        prop;
    console.log('Problem 3: Properties of the copy:');
    result += 'Properties of the copy:<br /><br />';

    for (prop in copy) {
        result += (prop + ': ' + copy[prop] + '<br />');
        console.log(prop + ': ' + copy[prop]);
    }

    console.log('Change a reference type property of the original object:');
    result += '<br />Change a reference type property of the original object:<br />';

    obj.arrayProperty[0] = 'This is changed';

    console.log('Object.arrayProperty: ' + obj.arrayProperty);
    result += 'Object.arrayProperty: ' + obj.arrayProperty +
        '<br />The copy is not changed:<br />copy.arrayProperty: ' + copy.arrayProperty;
    console.log('The copy is not changed:');
    console.log('copy.arrayProperty: ' + copy.arrayProperty);
    document.getElementById('pr3answer').innerHTML = result;
}

function createDeepCopy(obj){
    //Handle 3 simple types, null and undefined
    if(obj == null || typeof obj != 'object'){
        return obj;
    }

    //Handle Date
    if(obj instanceof Date){
        var copy = new Date();
        copy.setTime(obj.getTime());
        return copy;
    }

    //Handle Array
    if(obj instanceof  Array){
        var copy = [];
        for(var i = 0, len = obj.length; i < len ; i+=1){
            copy[i] = createDeepCopy(obj[i]);
        }
        return copy;
    }

    //Handle Object
    if(obj instanceof  Object){
        var copy = {};
        for(var attr in obj){
            if(obj.hasOwnProperty(attr)){
                copy[attr] = createDeepCopy(obj[attr]);
            }
        }
        return copy;
    }

    throw new Error("Unable to copy obj! Its type isn't supported.");
}

//Problem 4. Has property
//Write a function that checks if a given object contains a given property.

Object.prototype.hasOwnProperty = function(property){
    return this[property] !== undefined;
}


function problem4() {
    var obj = {
            stringProperty: 'this is a string',
            numberProperty: 5,
            arrayProperty: [1, 2, 3, 4, 5],
            objectProperty: {
                a: 5,
                b: 7,
                c: [1, 2, 3]
            }
        },
        property = document.getElementById('property').value;
    if (property !== '') {
        var hasProp = obj.hasOwnProperty(property);
        document.getElementById('pr4answer').innerHTML =
            'The object contains a property ' + property + ' with value ' + obj[property] + '.';
        console.log('Problem 4: The object contains a property ' + property + ' with value ' + obj[property] + '.');
    } else {
        document.getElementById('pr4answer').innerHTML =
            'Enter a property to look for';
    }
}


//Problem 5. Youngest person
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.


function Person(firstname, lastname, age) {
    firstname = firstname || '';
    lastname = lastname || '';
    age = age || null;
    return {
        'firstname': firstname,
        'lastname': lastname,
        'age': age
    };
}

function problem5(){
    var people = [
        new Person('Ivan', 'Ivanov', 50),
        new Person('Peter', 'Georgiev', 25),
        new Person('Georgi', 'Petrov', 70),
        new Person('Stefan', 'Nikolov', 50),
        new Person('Nikolai', 'Dimitrov', 25),
        new Person('Ivan', 'Georgiev', 28),
        new Person('Peter', 'Dimitrov', 28),
        new Person('Georgi', 'Ivanov', 50),
        new Person('Stefan', 'Petrov', 55),
        new Person('Nikolai', 'Nikolov', 25)
    ];

    var tableData = '<table><tr><td>FirstName</td><td>LastName</td><td>Age</td></tr>';
    Object.keys(people).forEach(function(key){
        console.log(key,people[key]);
        tableData += '<tr><td>'+people[key].firstname+'</td><td>'+people[key].lastname+'</td><td>'+people[key].age+'</td></tr>';
    });
    var _div = document.getElementById('peoples');
    _div.innerHTML = tableData;

    people.sort(function(a,b){
        return a.age - b.age;
    });

    var youngest = people[0];

    document.getElementById('pr5answer').innerHTML = youngest.firstname + ' ' + youngest.lastname + ' ' + youngest.age;
}

//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)

function group(){
        var i,
            len = arr.length,
            result = {};

    switch (prop){
        case 'firstname' :
            for(i = 0 ; i < len ; i+=1){
                if(result[arr[i].firstname]) {
                    result[arr[i].firstname].push(arr[i])
                }else{
                    result[arr[i].firstname] = [arr[i]];
                }
            }
            return result;
            break;
        case 'lastname' :
            for (i = 0; i < len; i += 1) {
                if (result[arr[i].lastname]) {
                    result[arr[i].lastname].push(arr[i]);
                } else {
                    result[arr[i].lastname] = [arr[i]];
                }
            }
            return result;
            break;
        case 'age' :
            for (i = 0; i < len; i += 1) {
                if (result[arr[i].age]) {
                    result[arr[i].age].push(arr[i]);
                } else {
                    result[arr[i].age] = [arr[i]];
                }
            }
            return result;
            break
    }
}


// Problem 6:

function printPeople(array, problemNumber) {
    var i,
        peopleElement = '',
        len = array.length;
    console.log('Problem ' + problemNumber + ':');

    for (i = 0; i < len; i += 1) {
        peopleElement +=
            array[i].firstname + ' ' +
            array[i].lastname + ', ' +
            array[i].age + '<br />';
        console.log(array[i].firstname + ' ' +
            array[i].lastname + ', ' +
            array[i].age);
    }
    document.getElementById('people' + problemNumber).innerHTML = peopleElement;
}

function generatePeople(problemNumber, attachFunction) {
    var people = [
        new Person('Ivan', 'Ivanov', 50),
        new Person('Peter', 'Georgiev', 25),
        new Person('Georgi', 'Petrov', 70),
        new Person('Stefan', 'Nikolov', 50),
        new Person('Nikolai', 'Dimitrov', 25),
        new Person('Ivan', 'Georgiev', 28),
        new Person('Peter', 'Dimitrov', 28),
        new Person('Georgi', 'Ivanov', 50),
        new Person('Stefan', 'Petrov', 55),
        new Person('Nikolai', 'Nikolov', 25)
    ];
    if (!document.getElementById('people' + problemNumber).innerHTML) {
        printPeople(people, problemNumber);
        document.getElementById('second-button' + problemNumber).addEventListener('click', attachFunction);
    } else {
        return people;
    }
}

function problem6() {

    var groupedByFirstName = group(generatePeople(6, problem6), 'firstname'),
        groupedByLastName = group(generatePeople(6, problem6), 'lastname'),
        groupedByAge = group(generatePeople(6, problem6), 'age'),
        resultConsole = '',
        resultHTML = '',
        prop;

    resultConsole += '\nGrouped by first name:\n\n';
    resultHTML += '<br />Grouped by first name:<br /><br />';
    for (prop in groupedByFirstName) {
        resultConsole += (prop + ': ' + printArrayOfObjects(groupedByFirstName[prop], 'console'));
        resultHTML += (prop + ': ' + printArrayOfObjects(groupedByFirstName[prop], 'html'));
    }
    resultConsole += '\nGrouped by last name:\n\n';
    resultHTML += '<br />Grouped by last name:<br /><br />';
    for (prop in groupedByLastName) {
        resultConsole += (prop + ': ' + printArrayOfObjects(groupedByLastName[prop], 'console'));
        resultHTML += (prop + ': ' + printArrayOfObjects(groupedByLastName[prop], 'HTML'));
    }
    resultConsole += '\nGrouped by age:\n\n';
    resultHTML += '<br />Grouped by age:<br /><br />';
    for (prop in groupedByAge) {
        resultConsole += (prop + ': ' + printArrayOfObjects(groupedByAge[prop], 'console'));
        resultHTML += (prop + ': ' + printArrayOfObjects(groupedByAge[prop], 'HTML'));
    }
    console.log(resultConsole);
    document.getElementById('pr6answer').innerHTML = resultHTML;
    document.getElementById('second-button6').removeEventListener('click', problem6);
}

function group(array, property) {
    var i,
        len = array.length,
        prop,
        result = {};

    if (property === 'firstname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].firstname]) {
                result[array[i].firstname].push(array[i]);
            } else {
                result[array[i].firstname] = [array[i]];
            }
        }
        return result;
    }
    if (property === 'lastname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].lastname]) {
                result[array[i].lastname].push(array[i]);
            } else {
                result[array[i].lastname] = [array[i]];
            }
        }
        return result;
    }
    if (property === 'age') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].age]) {
                result[array[i].age].push(array[i]);
            } else {
                result[array[i].age] = [array[i]];
            }
        }
        return result;
    }
}

function printArrayOfObjects(array, type) {
    var result = '',
        prop,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        for (prop in array[i]) {
            result += (prop + ': ' +
            array[i][prop] + '; ');
        }
        if (type === 'console') {
            result += '\n';
            if (i < len - 1) {
                result += '\t';
            }
        } else {
            result += '<br />';
            if (i < len - 1) {
                result += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            }
        }

    }
    return result;
}