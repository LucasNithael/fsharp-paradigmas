

open System

let solveQuadraticEquation a b c =
    let delta = b * b - 4.0 * a * c

    if delta < 0.0 then
        printfn "A equação não tem raízes reais."
    elif delta = 0.0 then
        let x = -b / (2.0 * a)
        printfn "A equação tem uma raiz real: x = %f" x
    else
        let sqrtDelta = Math.Sqrt(delta)
        let x1 = (-b + sqrtDelta) / (2.0 * a)
        let x2 = (-b - sqrtDelta) / (2.0 * a)
        printfn "A equação tem duas raízes reais: x1 = %f, x2 = %f" x1 x2

// Exemplo de uso:
solveQuadraticEquation 1.0 -3.0 2.0  // Saída esperada: x1 = 2.000000, x2 = 1.000000
