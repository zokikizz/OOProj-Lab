#pragma once
#include <iostream>

class Krug
{
protected:
	double x, y, r;
public:
	Krug(void);
	~Krug(void);
	Krug(double r)
	{
		this->r = r;
	};
	virtual void promeniR(double r)
	{
		this->r = r;
	};
	virtual void stampaj(void);
};
