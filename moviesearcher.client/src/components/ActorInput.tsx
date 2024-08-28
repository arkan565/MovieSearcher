import React from "react";
import { useActors } from "../hooks";

interface ActorInputProps {
	onChange: (value: string) => void;
}

const ActorInput: React.FC<ActorInputProps> = ({ onChange }) => {
	const { actors } = useActors();
	const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
		onChange(event.target.value);
	};

	return (
		<div>
			<input
				className="border border-gray-300 rounded-md px-2 py-1 h-full"
				placeholder="Actors"
				list="actorsList"
				autoComplete="off"
				type="text"
				onChange={handleInputChange}
			/>
			<datalist id="actorsList">
				{actors.map((actor, index) => (
					<option key={index}>{actor.name}</option>
				))}
			</datalist>
		</div>
	);
};

export default ActorInput;
