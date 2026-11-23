using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020011C5 RID: 4549
[eiz("B")]
[Serializable]
public sealed class dpz : s0
{
	// Token: 0x06006186 RID: 24966 RVA: 0x002A69D4 File Offset: 0x002A4BD4
	private dpz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("B:N");
	}

	// Token: 0x06006187 RID: 24967 RVA: 0x002A69F0 File Offset: 0x002A4BF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("B:N", this.a);
	}

	// Token: 0x06006188 RID: 24968 RVA: 0x002A6A0C File Offset: 0x002A4C0C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006189 RID: 24969 RVA: 0x002A6A14 File Offset: 0x002A4C14
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x002A6A20 File Offset: 0x002A4C20
	public override string ej()
	{
		return "Blueprints";
	}

	// Token: 0x0600618B RID: 24971 RVA: 0x002A6A28 File Offset: 0x002A4C28
	public dpz()
	{
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x002A6A34 File Offset: 0x002A4C34
	public override string ek(e3q A_0)
	{
		cwp cwp = d79.a(this.a);
		if (cwp != null)
		{
			return cwp.LocalizedName + (dpz.a(A_0, cwp) ? (" " + dh9.c("Blueprint_AlreadyObtained")) : "");
		}
		return "#ERROR: Blueprint not found";
	}

	// Token: 0x0600618D RID: 24973 RVA: 0x002A6A90 File Offset: 0x002A4C90
	public override string el(e3q A_0)
	{
		cwp cwp = d79.a(this.a);
		if (cwp != null)
		{
			return dh9.c("Blueprint_Downloaded") + ": " + cwp.Name;
		}
		return "#ERROR: Blueprint not found";
	}

	// Token: 0x0600618E RID: 24974 RVA: 0x002A6AD0 File Offset: 0x002A4CD0
	public override bool em(e3q A_0)
	{
		cwp cwp = d79.a(this.a);
		return cwp != null && !dpz.a(A_0, cwp);
	}

	// Token: 0x0600618F RID: 24975 RVA: 0x002A6AFC File Offset: 0x002A4CFC
	public override void en(e3q A_0, c5x A_1)
	{
		if (this.a != null && df6.a(this.a, A_0) && A_1 != null)
		{
			df6.a(A_1);
		}
	}

	// Token: 0x06006190 RID: 24976 RVA: 0x002A6B2C File Offset: 0x002A4D2C
	public override string eo(e3q A_0)
	{
		cwp cwp = d79.a(this.a);
		if (cwp != null)
		{
			return cwp.xi();
		}
		return "#ERROR: Blueprint not found";
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x002A6B58 File Offset: 0x002A4D58
	public override string ep(e3q A_0)
	{
		cwp cwp = d79.a(this.a);
		if (cwp != null)
		{
			return "Загрузка чертежа '" + cwp.Name + "'" + (dpz.a(A_0, cwp) ? " (уже получено)" : "");
		}
		return "#ERROR: Blueprint not found";
	}

	// Token: 0x06006192 RID: 24978 RVA: 0x002A6BB0 File Offset: 0x002A4DB0
	private static bool a(e3q A_0, cwp A_1)
	{
		dpz.a a = new dpz.a();
		a.a = A_1;
		return Enumerable.Any<bdc>(A_0.d(), new Func<bdc, bool>(a.a));
	}

	// Token: 0x04002971 RID: 10609
	private string a;

	// Token: 0x020011C6 RID: 4550
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06006194 RID: 24980 RVA: 0x002A6BEC File Offset: 0x002A4DEC
		internal bool a(bdc A_0)
		{
			return A_0.ao() == this.a;
		}

		// Token: 0x04002972 RID: 10610
		public cwp a;
	}
}
