    using UnityEngine;

    class Wand: MonoBehaviour, IFlame
    {
        float timer = 1f;
        int redShades = 4;

        void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0 && redShades >= 0)
            {
                Flame();
                redShades--;
                timer = 1f;
                if(redShades == 0)
                    Destroy(gameObject);
            }

        }
        public void Flame()
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, ((float)redShades/4));
        }
    }
