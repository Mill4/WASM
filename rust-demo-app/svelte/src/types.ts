export interface PokemonAbility {
    name: string;
    url: string;
}
export interface PokemonProps {
    name: string;
    url: string;
    abilities: {
        ability: PokemonAbility[];
    };
}
