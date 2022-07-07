for (($i = 0); $i -lt 40000; $i++)
{
 $m='UnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTestUnitTest' + $i;
 (Get-Content .\PrimeService_IsPrimeShould.cs) -Replace 'PrimeService_IsPrimeShould', $m | Set-Content .\MSTestUnit$i.cs
}
