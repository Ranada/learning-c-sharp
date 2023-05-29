``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1702/22H2/2022Update/SunValley2)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.302
  [Host] : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|         Method | FirstName | LastName | Balance | Mean | Error |
|--------------- |---------- |--------- |-------- |-----:|------:|
| InquireBalance |      John |      Doe |     100 |   NA |    NA |

Benchmarks with issues:
  Customer.InquireBalance: DefaultJob [FirstName=John, LastName=Doe, Balance=100]
