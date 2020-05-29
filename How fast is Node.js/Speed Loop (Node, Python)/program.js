const cycles = 1000000000;

const start = Date.now();

for (let i = 0; i < cycles; i++) {
  // Empty Loop
}

const end = Date.now();

const duration = (end - start) / 1000; // Seconds

console.log(`It took ${duration} seconds to process ${cycles} cycles in Node.js`);
