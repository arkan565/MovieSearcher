import React from "react";
import { useGenres } from "../hooks";

interface ActorInputProps {
	onChange: (value: number) => void;
}

const GenresInput: React.FC<ActorInputProps> = ({ onChange }) => {
	const { genres } = useGenres();

	return (
		<div className="flex justify-center items-center">
			<label className="text-white">Genres:</label>
			<select
				className="border border-gray-300 rounded-md px-2 py-1"
				onChange={(e) => onChange(parseInt(e.target.value))}
			>
				<option value={0}>All</option>
				{genres.map((genre) => (
					<option value={genre.id}>{genre.name}</option>
				))}
			</select>
		</div>
	);
};

export default GenresInput;
