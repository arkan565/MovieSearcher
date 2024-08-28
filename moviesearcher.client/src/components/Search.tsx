import { useState } from "react";
import { Search } from "../types";
import ActorInput from "./ActorInput";
import GenresInput from "./GenresInput";

interface SearchComponentProps {
	setSearch: (search: Search) => void;
}
export const SearchComponent = ({ setSearch }: SearchComponentProps) => {
	const [inputSearch, setInputSearch] = useState<Search>({
		title: "",
		actor: "",
	});
	return (
		<div className="flex gap-10">
			<ActorInput
				onChange={(value) => {
					setInputSearch((search) => ({ ...search, actor: value }));
				}}
			/>
			<GenresInput
				onChange={(value) =>
					setInputSearch((search) => ({ ...search, genre: value }))
				}
			/>
			<input
				placeholder="Title"
				type="text"
				onChange={(e) =>
					setInputSearch((search) => ({ ...search, title: e.target.value }))
				}
				className="border border-gray-300 rounded-md px-2 py-1"
			/>
			<button
				onClick={() => setSearch(inputSearch)}
				className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded"
			>
				Search
			</button>
		</div>
	);
};
