using System;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200014E RID: 334
[eiz("BC")]
[Serializable]
public class er1 : j4, ISerializable
{
	// Token: 0x06000845 RID: 2117 RVA: 0x00022D30 File Offset: 0x00020F30
	protected er1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("BC:V");
			return;
		}
		if (base.GetType() == typeof(er1))
		{
			this.a = A_0.GetBoolean("_Value");
			return;
		}
		this.a = A_0.GetBoolean("BoolCondition+_Value");
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00022DA0 File Offset: 0x00020FA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BC:V", this.a);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00022DBC File Offset: 0x00020FBC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00022DC4 File Offset: 0x00020FC4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00022DD0 File Offset: 0x00020FD0
	public er1()
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00022DDC File Offset: 0x00020FDC
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
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
			obj = false;
		}
		if (obj == null)
		{
			if (!base.c())
			{
				return false;
			}
			obj = false;
		}
		if (bool.TryParse(obj.ToString(), out flag))
		{
			return flag.Equals(this.a);
		}
		cvq cvq = dr3.e();
		string str = "Error evaluating condition " + base.h() + "Could not convert value specified by path to System.Boolean";
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 115))
		{
			cvq.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
		}
		return false;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00022EC0 File Offset: 0x000210C0
	public override string ToString()
	{
		return string.Format("{0}=={1}", base.d(), this.a);
	}

	// Token: 0x040005A5 RID: 1445
	private bool a;
}
