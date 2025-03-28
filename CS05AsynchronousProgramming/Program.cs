﻿using CS05AsynchronousProgramming;
using System.Diagnostics;

//var stopWatch = new Stopwatch();

//Console.WriteLine("SYNC operation");
//stopWatch.Start();
//SyncBreakfast.MakeSyncBreakfast();
//stopWatch.Stop();

//var tsSync = stopWatch.Elapsed;
//Console.WriteLine("### Sync time: " + tsSync);

Console.WriteLine("\nASYNC operations");
//stopWatch.Restart();
await AsyncBreakfast.MakeAsyncBreakfast();
//stopWatch.Stop();

//var tsAsync = stopWatch.Elapsed;
//Console.WriteLine("### Async time: " + tsAsync);

//Console.WriteLine("=> Cancellation Token");
//await TaskCancellation.ExecuteWithCancellationTokenAfterTime();

// Tratamento de exceções assíncronas

//AsyncException.CallExceptionAsync();
//await AsyncException.RunMultipleExceptions();
//Console.ReadKey();
