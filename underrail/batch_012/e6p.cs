using System;
using System.Runtime.Serialization;

// Token: 0x02001254 RID: 4692
[eiz("CICC")]
[Serializable]
public sealed class e6p : bak
{
	// Token: 0x06006564 RID: 25956 RVA: 0x002B3270 File Offset: 0x002B1470
	private e6p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CICC:V");
		this.b = (ei6)A_0.GetValue("CICC:C", typeof(ei6));
	}

	// Token: 0x06006565 RID: 25957 RVA: 0x002B32B8 File Offset: 0x002B14B8
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("CICC:V", this.a);
		info.AddValue("CICC:C", this.b);
	}

	// Token: 0x06006566 RID: 25958 RVA: 0x002B32EC File Offset: 0x002B14EC
	public int b()
	{
		return this.a;
	}

	// Token: 0x06006567 RID: 25959 RVA: 0x002B32F4 File Offset: 0x002B14F4
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006568 RID: 25960 RVA: 0x002B3300 File Offset: 0x002B1500
	public ei6 a()
	{
		return this.b;
	}

	// Token: 0x06006569 RID: 25961 RVA: 0x002B3308 File Offset: 0x002B1508
	public void a(ei6 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600656A RID: 25962 RVA: 0x002B3314 File Offset: 0x002B1514
	public e6p()
	{
	}

	// Token: 0x0600656B RID: 25963 RVA: 0x002B3320 File Offset: 0x002B1520
	public override string ji()
	{
		string str;
		switch (this.a())
		{
		case ei6.a:
			str = "==";
			break;
		case ei6.b:
			str = ">";
			break;
		case ei6.c:
			str = "<";
			break;
		case ei6.d:
			str = ">=";
			break;
		case ei6.e:
			str = "<=";
			break;
		case ei6.f:
			str = "!=";
			break;
		default:
			str = "==";
			break;
		}
		return "item count " + str + " " + this.a.ToString();
	}

	// Token: 0x0600656C RID: 25964 RVA: 0x002B33C4 File Offset: 0x002B15C4
	protected override bool xu(c5x A_0, e2f A_1)
	{
		if (A_0 == null)
		{
			return false;
		}
		c7j c7j = A_0.GetAspect<bim>() as c7j;
		int num = 0;
		if (c7j != null)
		{
			num = c7j.ItemContainer.z2().Count;
		}
		switch (this.b)
		{
		case ei6.a:
			return num == this.a;
		case ei6.b:
			return num > this.a;
		case ei6.c:
			return num < this.a;
		case ei6.d:
			return num >= this.a;
		case ei6.e:
			return num <= this.a;
		case ei6.f:
			return num != this.a;
		default:
			return false;
		}
	}

	// Token: 0x04002A3C RID: 10812
	private int a;

	// Token: 0x04002A3D RID: 10813
	private ei6 b;
}
