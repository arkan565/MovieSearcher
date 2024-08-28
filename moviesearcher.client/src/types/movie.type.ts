import { Actor } from "./actor.type";
import { Genre } from "./genre.type";

export interface Movie {
	movieId: number;
	year: number;
	title: string;
	description: string;
	genre: Genre[];
	actors: Actor[];
}
