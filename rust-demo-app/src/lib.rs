mod utils;

use wasm_bindgen::prelude::*;

// When the `wee_alloc` feature is enabled, use `wee_alloc` as the global
// allocator.
#[cfg(feature = "wee_alloc")]
#[global_allocator]
static ALLOC: wee_alloc::WeeAlloc = wee_alloc::WeeAlloc::INIT;

#[wasm_bindgen]
pub fn calculate_length(name: String) -> u32 {
    name.len() as u32
}

#[wasm_bindgen]
pub fn calculate_how_many_char(name: String, c: char) -> u32 {
    let mut count = 0;
    name.chars().for_each(|x| {
        if x == c {
            count += 1
        }
    });
    count
}


