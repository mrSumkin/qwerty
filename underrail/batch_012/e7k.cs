using System;
using System.Globalization;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02000154 RID: 340
[eiz("ICC")]
[Serializable]
public class e7k : j4, ISerializable
{
	// Token: 0x0600086D RID: 2157 RVA: 0x0002378C File Offset: 0x0002198C
	protected e7k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			if (ell.b() >= 34)
			{
				this.a = (A_0.GetValue("ICC:V", typeof(int?)) as int?);
			}
			else
			{
				this.a = new int?(A_0.GetInt32("ICC:V"));
			}
			this.b = (ei6)A_0.GetValue("ICC:CT", typeof(ei6));
			return;
		}
		if (base.GetType() == typeof(e7k))
		{
			this.a = new int?(A_0.GetInt32("_Value"));
			this.b = (ei6)A_0.GetValue("_ComparationType", typeof(ei6));
			return;
		}
		this.a = new int?(A_0.GetInt32("IntegerComaprisonCondition+_Value"));
		this.b = (ei6)A_0.GetValue("IntegerComaprisonCondition+_ComparationType", typeof(ei6));
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000238AC File Offset: 0x00021AAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ICC:V", this.a);
		info.AddValue("ICC:CT", this.b);
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x000238E4 File Offset: 0x00021AE4
	public int? b()
	{
		return this.a;
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x000238EC File Offset: 0x00021AEC
	public void a(int? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x000238F8 File Offset: 0x00021AF8
	public ei6 a()
	{
		return this.b;
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00023900 File Offset: 0x00021B00
	public void a(ei6 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0002390C File Offset: 0x00021B0C
	public e7k()
	{
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00023920 File Offset: 0x00021B20
	public e7k(int? A_0, ei6 A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00023948 File Offset: 0x00021B48
	public override bool cw(bq8 A_0, bq8 A_1)
	{
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
			obj = 0;
		}
		if (obj == null && base.c())
		{
			obj = 0;
		}
		int? num;
		if (obj == null)
		{
			num = null;
		}
		else
		{
			int value;
			if (!int.TryParse(obj.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out value))
			{
				cvq cvq = dr3.e();
				string str = "Error evaluating condition " + base.h() + "Could not convert value specified by path to System.Int32";
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 115))
				{
					cvq.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
				}
				return false;
			}
			num = new int?(value);
		}
		switch (this.a())
		{
		case ei6.a:
		{
			int? num2 = num;
			int? num3 = this.a;
			return num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null);
		}
		case ei6.b:
		{
			int? num2 = num;
			int? num3 = this.a;
			return num2.GetValueOrDefault() > num3.GetValueOrDefault() & (num2 != null & num3 != null);
		}
		case ei6.c:
		{
			int? num3 = num;
			int? num2 = this.a;
			return num3.GetValueOrDefault() < num2.GetValueOrDefault() & (num3 != null & num2 != null);
		}
		case ei6.d:
		{
			int? num2 = num;
			int? num3 = this.a;
			return num2.GetValueOrDefault() >= num3.GetValueOrDefault() & (num2 != null & num3 != null);
		}
		case ei6.e:
		{
			int? num3 = num;
			int? num2 = this.a;
			return num3.GetValueOrDefault() <= num2.GetValueOrDefault() & (num3 != null & num2 != null);
		}
		case ei6.f:
		{
			int? num3 = num;
			int? num2 = this.a;
			return !(num3.GetValueOrDefault() == num2.GetValueOrDefault() & num3 != null == (num2 != null));
		}
		default:
			return false;
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00023B7C File Offset: 0x00021D7C
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
		return string.Format("{0} {1} {2}", base.d(), arg, this.a);
	}

	// Token: 0x040005AB RID: 1451
	private int? a = new int?(0);

	// Token: 0x040005AC RID: 1452
	private ei6 b;
}
