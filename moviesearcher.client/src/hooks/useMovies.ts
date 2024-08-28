import { useState } from "react";
import { useEffect } from "react";
import { Search } from "../types/search.type";
import { Movie } from "../types/movie.type";

interface MovieResponse {
	MovieId: number;
	Year: number;
	Title: string;
	Description: string;
	Genre: GenreResponse[];
	Actors: ActorResponse[];
}

interface GenreResponse {
	GenreId: number;
	Genre: string;
	Movies: any[];
}

interface ActorResponse {
	ActorId: number;
	ActorName: string;
	Movies: any[];
}

export const useMovies = ({ title, actor, genre }: Search) => {
	const [movies, setMovies] = useState<Movie[]>([]);

	async function fetchActors() {
		const genreString = genre ? `&&genre=${genre}` : "";
		const response = await fetch(
			`https://localhost:7151/api/Movies?title=${title}&&actor=${actor}${genreString}`
		);
		const moviesResponse = await response.json();
		setMovies(
			moviesResponse.map((movie: MovieResponse) => ({
				movieId: movie.MovieId,
				year: movie.Year,
				title: movie.Title,
				description: movie.Description,
				genre: movie.Genre.map((genre) => ({
					id: genre.GenreId,
					name: genre.Genre,
					movies: genre.Movies,
				})),
				actors: movie.Actors.map((actor) => ({
					id: actor.ActorId,
					name: actor.ActorName,
					movies: actor.Movies,
				})),
			}))
		);
	}
	useEffect(() => {
		fetchActors();
	}, [title, actor, genre]);

	return { movies };
};
