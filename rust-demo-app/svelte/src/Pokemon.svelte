<script lang="ts">
    import init, {
        calculate_how_many_char,
    } from "rust-demo-app";
    import { pokemonList } from "./pokemons";

    async function run() {
        await init();
        calculate(100)
        calculate(10000)
        calculate(100000)
        calculate(500000)
    }
    

    function calculate(times) {
        console.time(`calculate${times}`);
        for (let i = 0; i < times; i++) {
            pokemonList.forEach(p => {
                let numberOfA = calculate_how_many_char(p, "a");
            })   
        }
        console.timeEnd(`calculate${times}`);
    }

    setTimeout(async () => {
        console.log(`Number of pokemons: ${pokemonList.length}`)
        await run();
    }, 0);
</script>

<main>Rust wasm</main>