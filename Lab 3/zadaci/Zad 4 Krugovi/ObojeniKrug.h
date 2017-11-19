#pragma once
#include "krug.h"

class ObojeniKrug :	public Krug
{
protected:
	int R, G, B;
public:
	ObojeniKrug(void);
	ObojeniKrug(int r1, int g1, int b1, int poluprecnik) 
		: Krug(poluprecnik)
	{
		R = r1;
		G = g1;
		B = b1;
	}
	~ObojeniKrug(void);
	virtual void promeniR(double r)
	{
		this->r += r;
	};
	virtual void stampaj();
};
