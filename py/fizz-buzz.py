def fizz_buzz(n):
  ans = ''
  if n % 3 == 0:
    ans = 'Fizz'
  if n % 5 == 0:
    ans = ans + 'Buzz'
  if ans:
    return ans
  else:
    return n 
  
for n in range(1,101):
  print(fizz_buzz(n))
