import { Movie } from "./movie.type";

export interface Genre {
	id: number;
	name: string;
	Movies: Movie[];
}
