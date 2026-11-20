using System;
using System.Globalization;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02000153 RID: 339
[eiz("FCC")]
[Serializable]
public class es5 : j4, ISerializable
{
	// Token: 0x06000864 RID: 2148 RVA: 0x00023454 File Offset: 0x00021654
	protected es5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetSingle("FCC:V");
			this.b = (ei6)A_0.GetValue("FCC:CT", typeof(ei6));
			return;
		}
		if (base.GetType() == typeof(es5))
		{
			this.a = A_0.GetSingle("_Value");
			this.b = (ei6)A_0.GetValue("_ComparationType", typeof(ei6));
			return;
		}
		this.a = A_0.GetSingle("FloatComparisonCondition+_Value");
		this.b = (ei6)A_0.GetValue("FloatComparisonCondition+_ComparationType", typeof(ei6));
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00023524 File Offset: 0x00021724
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FCC:V", this.a);
		info.AddValue("FCC:CT", this.b);
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00023558 File Offset: 0x00021758
	public float b()
	{
		return this.a;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00023560 File Offset: 0x00021760
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002356C File Offset: 0x0002176C
	public ei6 a()
	{
		return this.b;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00023574 File Offset: 0x00021774
	public void a(ei6 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00023580 File Offset: 0x00021780
	public es5()
	{
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002358C File Offset: 0x0002178C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		float num = 0f;
		object obj = null;
		try
		{
			obj = d8z.a(A_0, A_1, base.d());
		}
		catch
		{
			if (!base.c())
			{
				throw;
			}
			obj = 0f;
		}
		if (obj == null)
		{
			if (!base.c())
			{
				return false;
			}
			obj = 0f;
		}
		if (!float.TryParse(obj.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num))
		{
			cvq cvq = dr3.e();
			string str = "Error evaluating condition " + base.h() + "Could not convert value specified by path to System.Single";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 115))
			{
				cvq.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
			}
			return false;
		}
		switch (this.a())
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

	// Token: 0x0600086C RID: 2156 RVA: 0x000236EC File Offset: 0x000218EC
	public override string ToString()
	{
		string arg;
		switch (this.a())
		{
		case ei6.a:
			arg = "==";
			break;
		case ei6.b:
			arg = ">";
			break;
		case ei6.c:
			arg = "<";
			break;
		case ei6.d:
			arg = ">=";
			break;
		case ei6.e:
			arg = "<=";
			break;
		case ei6.f:
			arg = "!=";
			break;
		default:
			arg = "==";
			break;
		}
		return string.Format("{0}{1}{0}", base.d(), arg, this.a);
	}

	// Token: 0x040005A9 RID: 1449
	private float a;

	// Token: 0x040005AA RID: 1450
	private ei6 b;
}
