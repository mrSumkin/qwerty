using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B4A RID: 6986
[eiz("DRAIM")]
[Serializable]
public abstract class ani : c3e
{
	// Token: 0x0600971C RID: 38684 RVA: 0x003AFFEC File Offset: 0x003AE1EC
	protected ani(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600971D RID: 38685 RVA: 0x003AFFF8 File Offset: 0x003AE1F8
	protected ani()
	{
	}

	// Token: 0x0600971E RID: 38686
	public abstract void ah7(Dictionary<DamageType, du2> A_0, cwt A_1, cgk A_2, efk A_3);
}
