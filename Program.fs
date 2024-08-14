﻿// 1. Olá Mundo
// [<EntryPoint>]
// let main argv =
//     printfn "Olá Mundo"
//     0  // Código de saída

// 2. Sequência de Fibonacci usando Recursão
// let rec fibonacci n =
//     if n <= 1 then n
//     else fibonacci (n - 1) + fibonacci (n - 2)

// // Exemplo de uso
// printfn "Fibonacci de 10 é: %d" (fibonacci 10)  // Saída: 55

// 3. Ordenação usando QuickSort (Sem usar variáveis, apenas valores)
// let rec quicksort list =
//     match list with
//     | [] -> []
//     | pivot :: tail ->
//         let smallerOrEqual = [ for x in tail do if x <= pivot then yield x ]
//         let larger = [ for x in tail do if x > pivot then yield x ]
//         quicksort smallerOrEqual @ [pivot] @ quicksort larger

// // Exemplo de uso
// let sortedList = quicksort [3; 6; 8; 5; 2; 7; 4; 1]
// printfn "%A" sortedList  // Saída: [1; 2; 3; 4; 5; 6; 7; 8]

