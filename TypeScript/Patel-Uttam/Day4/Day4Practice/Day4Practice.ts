console.log('Typescript Day4 practice');


// Map

let Personmap = new Map();


//set

Personmap.set('Raj',20);
Personmap.set('Kunj',22);
Personmap.set('Rutu',18);
Personmap.set('Shubh',15);
Personmap.set('Riya',23);
Personmap.set(23,'Abhi');
Personmap.set('Raj',20);


//get

console.log(Personmap.get('Raj'));
console.log(Personmap.get(23));


// delete

Personmap.delete('Raj');

// has

console.log(Personmap.has('Raj'));

//size
console.log(Personmap.size);

// clear

Personmap.clear();

console.log(Personmap.size);




// Set  

let ColorSet = new Set();

ColorSet.add('Red');
ColorSet.add('Pink');
ColorSet.add('Blue');
ColorSet.add('Dark');
ColorSet.add('White');

// 
for(var value of ColorSet)
{
    console.log(value);
}

//delete

ColorSet.delete('Red');

// has 

console.log(ColorSet.has('Red'));
console.log(ColorSet.has('Dark'));

//clear
ColorSet.clear();

//size
console.log(ColorSet.size);


//date