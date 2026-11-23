using System;
using System.Runtime.Serialization;

// Token: 0x02001255 RID: 4693
[eiz("ESTC")]
[Serializable]
public abstract class bak : dth, ISerializable
{
	// Token: 0x0600656D RID: 25965 RVA: 0x002B3470 File Offset: 0x002B1670
	protected bak(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 500)
		{
			this.a = (bvl)A_0.GetValue("ESTC:S", typeof(bvl));
			this.b = A_0.GetString("ESTC:A");
			this.c = (A_0.GetValue("ESTC:I", typeof(Guid?)) as Guid?);
		}
	}

	// Token: 0x0600656E RID: 25966 RVA: 0x002B34F0 File Offset: 0x002B16F0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("ESTC:S", this.a);
		info.AddValue("ESTC:A", this.b);
		info.AddValue("ESTC:I", this.c);
	}

	// Token: 0x0600656F RID: 25967 RVA: 0x002B3530 File Offset: 0x002B1730
	public bvl e()
	{
		return this.a;
	}

	// Token: 0x06006570 RID: 25968 RVA: 0x002B3538 File Offset: 0x002B1738
	public void a(bvl A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006571 RID: 25969 RVA: 0x002B3544 File Offset: 0x002B1744
	public string c()
	{
		return this.b;
	}

	// Token: 0x06006572 RID: 25970 RVA: 0x002B354C File Offset: 0x002B174C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006573 RID: 25971 RVA: 0x002B3558 File Offset: 0x002B1758
	public Guid? d()
	{
		return this.c;
	}

	// Token: 0x06006574 RID: 25972 RVA: 0x002B3560 File Offset: 0x002B1760
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006575 RID: 25973 RVA: 0x002B356C File Offset: 0x002B176C
	public bak()
	{
	}

	// Token: 0x06006576 RID: 25974 RVA: 0x002B357C File Offset: 0x002B177C
	public virtual string ji()
	{
		string str;
		if (this.a == bvl.e)
		{
			if (this.c != null)
			{
				str = this.c.Value.ToString();
				if (!string.IsNullOrEmpty(this.b))
				{
					str = str + " in " + this.b;
				}
			}
			else
			{
				str = "unknown";
			}
		}
		else if (this.a == bvl.b)
		{
			str = "initiator";
		}
		else if (this.a == bvl.d)
		{
			str = "player";
		}
		else
		{
			str = "target";
		}
		return str + " is ";
	}

	// Token: 0x06006577 RID: 25975 RVA: 0x002B3634 File Offset: 0x002B1834
	public bool jh(object A_0)
	{
		e2f e2f = A_0 as e2f;
		if (e2f != null)
		{
			c5x c5x = this.a(e2f);
			if (c5x != null)
			{
				return this.xu(c5x, e2f);
			}
		}
		return false;
	}

	// Token: 0x06006578 RID: 25976
	protected abstract bool xu(c5x A_0, e2f A_1);

	// Token: 0x06006579 RID: 25977 RVA: 0x002B3668 File Offset: 0x002B1868
	private c5x a(e2f A_0)
	{
		c5x result = null;
		if (this.a == bvl.e)
		{
			aud aud = cze.a(this.b, A_0.a, A_0.b, A_0.c);
			if (aud != null && this.c != null)
			{
				result = (aud.a(this.c.Value) as c5x);
			}
		}
		else if (this.a == bvl.c)
		{
			result = (A_0.b as c5x);
		}
		else if (this.a == bvl.b)
		{
			result = (A_0.a as c5x);
		}
		else if (this.a == bvl.d)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				result = (serviceOrThrow.aqu().v().b() as c5x);
			}
			else
			{
				result = null;
			}
		}
		else
		{
			result = (A_0.b as c5x);
		}
		return result;
	}

	// Token: 0x04002A3E RID: 10814
	private bvl a = bvl.c;

	// Token: 0x04002A3F RID: 10815
	private string b;

	// Token: 0x04002A40 RID: 10816
	private Guid? c;
}
