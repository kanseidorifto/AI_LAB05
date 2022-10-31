namespace AI_LAB05.Interfaces
{
    interface INeuron
    {
        public float GetAnswer(ISignals signals);
        public float GetWeight(int index);
        public void CorrectWeight(float delta_w, ISignals signals);
    }
}
