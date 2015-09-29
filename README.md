# htmlagilitypack-test-microbenchmark
Micro benchmark to test different ways to navigate a tree of nodes

# Results

I expected the xpath version to be faster, but apparently they're equivalent:

<pre>
test-speed [master +6 ~0 -0 !]> scriptcs .\test.csx
Benchmark                             Mean Mean-Error   Sdev  Unit
TestIteration                        4,469      1,406  0,930 ms/op
TestPath                             3,818      0,372  0,246 ms/op
</pre>

# How to repro

<pre>
scriptcs -install
scriptcs .\test.csx
</pre>
