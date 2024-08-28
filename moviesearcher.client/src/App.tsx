import { useState } from "react";
import { useMovies } from "./hooks";
import "./App.css";
import { Search } from "./types/search.type";
import { SearchComponent } from "./components/Search";
import MovieList from "./components/MovieList";

function App() {
	const [search, setSearch] = useState<Search>({
		title: "",
		actor: "",
	});
	const { movies } = useMovies(search);

	return (
		<div className="w-full h-full bg-gray-900 items-center justify-between p-0 m-0">
			<header className="flex w-full h-full bg-black items-center justify-between p-5">
				<h1 className="text-3xl text-white">Movie Search</h1>
				<SearchComponent setSearch={setSearch} />
			</header>
			<MovieList movies={movies} />
		</div>
	);
}

export default App;
