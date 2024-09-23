# SQLite + Blazor WASM

Goal:
client scoped, persisted storage in the browser.

Conclusion:
Possible to use SQLite in both Blazor client-side & even use EFCore. But, without additional browser caching to persist the SQLite database, nothing is being persisted between page refreshes.

Tutorial:
[How to use SQLite in your Blazor WebAssembly apps](https://www.youtube.com/watch?v=ZeJISZgy-FM)
