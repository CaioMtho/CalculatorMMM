class Calculo{
    // Classe de operações
        public double Media(List<float> lista)
        {
            // retorna a media
            return lista.Sum() / lista.Count();

        }
        public float Moda(List<float> lista)
        {
            //retorna o valor mais comum

            return lista.GroupBy(i => i).OrderByDescending(grp => grp.Count())
            .Select(grp => grp.Key).First(); ;
        }
        public float Mediana(List<float> lista)
        {
            // copia ordenada da lista
            List<float> floatSorted = lista.ToList();
            floatSorted.Sort();

            // mediana de lista pares
            if (lista.Count() % 2 == 0)
            {
                int md1 = (int)Math.Round(floatSorted.Count / 2.0f - 1, 0);
                int md2 = (int)Math.Round(floatSorted.Count / 2.0f);


                float valorMediana = ((floatSorted[md1] + floatSorted[md2]) / 2.0f);

                return valorMediana;
            }
            else
            {
                // mediana de listas impares
                int md = Convert.ToInt32(Math.Ceiling(floatSorted.Count / 2.0f) - 1);
                return floatSorted[md];
            }
        }
}