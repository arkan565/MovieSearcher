import React from "react";

import { Movie } from "../types";

interface MovieListProps {
	movies: Movie[];
}

const MovieList: React.FC<MovieListProps> = ({ movies }) => {
	return (
		<div className="grid grid-cols-3 gap-4 p-2">
			{movies.map((movie) => (
				<div key={movie.movieId} className="bg-white p-4 shadow-md">
					<h2 className="text-xl font-bold">{movie.title}</h2>
					<p className="text-gray-500">{movie.description}</p>
				</div>
			))}
		</div>
	);
};

export default MovieList;
