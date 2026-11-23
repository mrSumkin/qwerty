using System;
using System.Runtime.Serialization;

// Token: 0x0200049E RID: 1182
[eiz("VER")]
[Serializable]
public sealed class ud : ISerializable
{
	// Token: 0x06001E20 RID: 7712 RVA: 0x000A6DA0 File Offset: 0x000A4FA0
	private ud(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("VER:N");
			this.b = A_0.GetValue("VER:C", typeof(object));
			return;
		}
		if (base.GetType() == typeof(ud))
		{
			this.a = A_0.GetString("Name");
			this.b = A_0.GetValue("Context", typeof(object));
			return;
		}
		this.a = A_0.GetString("VisualEffectReference+Name");
		this.b = A_0.GetValue("VisualEffectReference+Context", typeof(object));
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x000A6E60 File Offset: 0x000A5060
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VER:N", this.a);
		info.AddValue("VER:C", this.b);
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x000A6E84 File Offset: 0x000A5084
	public ud(object A_0, string A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x000A6E9C File Offset: 0x000A509C
	public override bool Equals(object obj)
	{
		ud ud = obj as ud;
		return ud != null && d05.a(ud.a, this.a, StringComparison.Ordinal);
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x000A6ECC File Offset: 0x000A50CC
	public override int GetHashCode()
	{
		if (this.a == null)
		{
			return 0;
		}
		return this.a.GetHashCode();
	}

	// Token: 0x040012A0 RID: 4768
	public string a;

	// Token: 0x040012A1 RID: 4769
	public object b;
}
