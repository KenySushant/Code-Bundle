import time

def main():
  cycles = 1000000000
  start = time.perf_counter()

  for i in range(0, cycles):
    pass # Empty Loop

  end = time.perf_counter()
  duration = end - start
  print("It took %.3f seconds to process %d cycles in Python" % (duration, cycles))

main()
