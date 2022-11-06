using System.Collections.Generic;

namespace CSE210_Greed.Game.Casting
{
    public class Cast
    {
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();

        /// <summary>
        /// Constructor for Cast instances
        /// </summary>
        public Cast(){}

        /// <summary>
        /// Adds the given actor to the given group (makes a new group if group is unrecognized).
        /// </summary>
        /// <param name="group">The name of the group to be added to</param>
        /// <param name="actor">The instance of Actor to add</param>            
        public void AddActor(string group, Actor actor)
        { //if the key has not been added yet...
            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor))
            { //if the list associated with the key does not already contain the specified instance of actor...
                actors[group].Add(actor);
            }
        }

        /// <summary>
        /// Returns all the actors in the cast.
        /// </summary>
        /// <param name="group">The group name</param>
        /// <returns>the list of actors, or an empty list if there aren't any</returns>
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        /// <summary>
        /// Takes the group name and returns the actors in the given group. Returns an empty list if there aren't any.
        /// </summary>
        /// <param name="group">The group name</param>
        /// <returns>The actors in the given group, or an empty list if there aren't any</returns>
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (actors.ContainsKey(group))
            {
                results.AddRange(actors[group]);
            }
            return results;
        }

        /// <summary>
        /// Returns the first actor in the given group
        /// </summary>
        /// <param name="group">The given group</param>
        /// <returns>The first actor in the given group</returns>
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (actors.ContainsKey(group))
            {
                if (actors[group].Count > 0){
                    result = actors[group][0];
                }
            }
            return result;
        }

        /// <summary>
        /// Removes the given actor from the given group
        /// </summary>
        /// <param name="group">The given group</param>
        /// <param name="actor">The given actor (will be removed)</param>
        public void RemoveActor(string group, Actor actor)
        {
            if (actors.ContainsKey(group))
            {
                actors[group].Remove(actor);
            }
        }
    }
}