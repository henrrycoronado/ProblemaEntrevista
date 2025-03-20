## Maximizar Ganancia en Trading de Acciones

Se te da una secuencia de precios de una acción representando el valor de dicha acción en días consecutivos. Puedes realizar tantas transacciones como desees bajo las siguientes condiciones:

- Debes comprar antes de vender.
- No puedes comprar y vender en el mismo día.

El objetivo es maximizar la ganancia total bajo estas reglas.

### Ejemplos:

1. `stock_prices = [7, 1, 5, 3, 6, 4]`
   - Salida esperada: `7`
   - Explicación: Comprar en día 2 (precio 1), vender en día 3 (precio 5), comprar en día 4 (precio 3) y vender en día 5 (precio 6).

2. `stock_prices = [1, 2, 3, 4, 5]`
   - Salida esperada: `4`
   - Explicación: Comprar en día 1 (precio 1) y vender en día 5 (precio 5).

3. `stock_prices = [7, 6, 4, 3, 1]`
   - Salida esperada: `0`
   - Explicación: No hay transacciones rentables.

4. `stock_prices = [1, 10, 2, 3]`
   - Salida esperada: `9`
   - Explicación: Comprar en día 1 (precio 1) y vender en día 2 (precio 10).
