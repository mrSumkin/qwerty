using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x020019B9 RID: 6585
[eiz("SE2")]
[Serializable]
public abstract class d3e : IComparable<d3e>, ISerializable, cq6
{
	// Token: 0x06008CDD RID: 36061 RVA: 0x00392028 File Offset: 0x00390228
	protected d3e(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("SE2:P");
		if (ell.a() >= 156)
		{
			this.b = (A_0.GetValue("SE2:C", typeof(dth)) as dth);
		}
		if (ell.a() >= 567)
		{
			this.c = A_0.GetBoolean("SE2:V");
		}
	}

	// Token: 0x06008CDE RID: 36062 RVA: 0x0039209C File Offset: 0x0039029C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SE2:P", this.a);
		info.AddValue("SE2:C", this.b);
		info.AddValue("SE2:V", this.c);
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06008CDF RID: 36063 RVA: 0x003920D4 File Offset: 0x003902D4
	// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x003920DC File Offset: 0x003902DC
	[XmlAttribute]
	public int Priority
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x003920E8 File Offset: 0x003902E8
	public virtual bool Negative
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x003920EC File Offset: 0x003902EC
	// (set) Token: 0x06008CE3 RID: 36067 RVA: 0x003920F4 File Offset: 0x003902F4
	public dth Condition
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06008CE4 RID: 36068 RVA: 0x00392100 File Offset: 0x00390300
	// (set) Token: 0x06008CE5 RID: 36069 RVA: 0x00392108 File Offset: 0x00390308
	public bool ConditionalVisibility
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x06008CE6 RID: 36070 RVA: 0x00392114 File Offset: 0x00390314
	protected d3e()
	{
	}

	// Token: 0x06008CE7 RID: 36071 RVA: 0x0039211C File Offset: 0x0039031C
	public void a(ll A_0)
	{
		if (this.b == null || this.b.jh(A_0))
		{
			this.@in(A_0);
		}
	}

	// Token: 0x06008CE8 RID: 36072 RVA: 0x00392144 File Offset: 0x00390344
	public int CompareTo(d3e other)
	{
		if (other == null || other.Priority == this.Priority)
		{
			return -1;
		}
		return this.Priority.CompareTo(other.Priority);
	}

	// Token: 0x06008CE9 RID: 36073
	public abstract d3e b3();

	// Token: 0x06008CEA RID: 36074 RVA: 0x00392180 File Offset: 0x00390380
	public sealed override string ToString()
	{
		string text;
		try
		{
			text = this.b2();
			if (string.IsNullOrEmpty(text))
			{
				text = base.GetType().Name;
			}
		}
		catch
		{
			text = "#Error" + base.GetType().Name;
		}
		if (this.b != null)
		{
			y9 y = this.b as y9;
			if (y != null)
			{
				string text2 = null;
				try
				{
					text2 = y.jj();
				}
				catch
				{
					text2 = "#Error";
				}
				if (!string.IsNullOrEmpty(text2))
				{
					text = text + " " + text2;
				}
			}
			else
			{
				string text3 = null;
				try
				{
					text3 = this.b.ji();
				}
				catch
				{
					text3 = "#Error";
				}
				if (!string.IsNullOrEmpty(text3))
				{
					text += string.Format(" ({0})", text3.ToLowerInvariant());
				}
			}
		}
		return text;
	}

	// Token: 0x06008CEB RID: 36075 RVA: 0x0039228C File Offset: 0x0039048C
	public virtual string b2()
	{
		return string.Empty;
	}

	// Token: 0x06008CEC RID: 36076
	protected abstract void @in(ll A_0);

	// Token: 0x06008CED RID: 36077 RVA: 0x00392294 File Offset: 0x00390494
	protected virtual void xx(d3e A_0)
	{
		A_0.b = this.b;
		A_0.a = this.a;
		A_0.c = this.c;
	}

	// Token: 0x040037AA RID: 14250
	private int a;

	// Token: 0x040037AB RID: 14251
	private dth b;

	// Token: 0x040037AC RID: 14252
	private bool c;
}
