import { useState } from "react";
import { useEffect } from "react";
import { Actor } from "../types";

interface ActorResponse {
	actorId: number;
	actorName: string;
}

export const useActors = () => {
	const [actors, setActors] = useState<Actor[]>([]);
	async function fetchActors() {
		const response = await fetch("https://localhost:7151/api/Actor");
		const actors: ActorResponse[] = await response.json();
		setActors(
			actors.map((actor) => ({ id: actor.actorId, name: actor.actorName }))
		);
	}
	useEffect(() => {
		fetchActors();
	}, []);

	return { actors };
};
