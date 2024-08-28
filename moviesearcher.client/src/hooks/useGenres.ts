import { useState } from "react";
import { useEffect } from "react";
import { Genre } from "../types";

interface GenreResponse {
	genreId: number;
	genre: string;
	movies: any[];
}

export const useGenres = () => {
	const [genres, setGenres] = useState<Genre[]>([]);
	async function fetchGenres() {
		const response = await fetch("https://localhost:7151/api/Genre");
		const genres = await response.json();
		setGenres(
			genres.map((genre: GenreResponse) => ({
				id: genre.genreId,
				name: genre.genre,
				movies: genre.movies,
			}))
		);
	}
	useEffect(() => {
		fetchGenres();
	}, []);

	return { genres };
};
