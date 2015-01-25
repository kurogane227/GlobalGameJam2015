// Shader created with Shader Forge v1.04 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.04;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:0,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:0,bdst:1,culm:0,dpts:2,wrdp:True,dith:2,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.0627451,fgcg:0.1019608,fgcb:0.3058824,fgca:1,fgde:0.005,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:8097,x:32719,y:32712,varname:node_8097,prsc:2|emission-8514-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:9305,x:31719,y:32548,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_9305,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3797,x:32024,y:32554,varname:node_3797,prsc:2,ntxv:0,isnm:False|TEX-9305-TEX;n:type:ShaderForge.SFN_Multiply,id:7527,x:32213,y:32665,varname:node_7527,prsc:2|A-3797-RGB,B-2921-RGB;n:type:ShaderForge.SFN_Color,id:2921,x:32013,y:32749,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_2921,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Tex2d,id:4993,x:31836,y:32964,varname:node_4993,prsc:2,ntxv:0,isnm:False|UVIN-387-OUT,TEX-6890-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:6890,x:31549,y:32849,ptovrint:False,ptlb:ScrollingTex,ptin:_ScrollingTex,varname:node_6890,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:3865,x:30981,y:32972,varname:node_3865,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:8946,x:31290,y:33115,varname:node_8946,prsc:2|A-3865-U,B-655-OUT;n:type:ShaderForge.SFN_Time,id:7857,x:30704,y:33203,varname:node_7857,prsc:2;n:type:ShaderForge.SFN_Append,id:387,x:31751,y:33255,varname:node_387,prsc:2|A-8946-OUT,B-2801-OUT;n:type:ShaderForge.SFN_Multiply,id:655,x:31090,y:33293,varname:node_655,prsc:2|A-7857-T,B-5228-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5228,x:30877,y:33509,ptovrint:False,ptlb:ScrollSpeed_U,ptin:_ScrollSpeed_U,varname:node_5228,prsc:2,glob:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8688,x:32141,y:33123,varname:node_8688,prsc:2|A-4993-RGB,B-7223-RGB;n:type:ShaderForge.SFN_Color,id:7223,x:31965,y:33245,ptovrint:False,ptlb:ScrollTexColor,ptin:_ScrollTexColor,varname:node_7223,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:9210,x:32368,y:32924,varname:node_9210,prsc:2|A-7527-OUT,B-8688-OUT;n:type:ShaderForge.SFN_Add,id:2801,x:31290,y:32906,varname:node_2801,prsc:2|A-9124-OUT,B-3865-V;n:type:ShaderForge.SFN_Multiply,id:9124,x:31102,y:32691,varname:node_9124,prsc:2|A-1322-T,B-7134-OUT;n:type:ShaderForge.SFN_Time,id:1322,x:30739,y:32650,varname:node_1322,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:7134,x:30895,y:32769,ptovrint:False,ptlb:ScrollSpeed_V,ptin:_ScrollSpeed_V,varname:node_7134,prsc:2,glob:False,v1:0.2;n:type:ShaderForge.SFN_Add,id:8514,x:32540,y:32834,varname:node_8514,prsc:2|A-7527-OUT,B-9210-OUT;proporder:9305-2921-6890-5228-7223-7134;pass:END;sub:END;*/

Shader "GGJ/RetroLights" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _ScrollingTex ("ScrollingTex", 2D) = "white" {}
        _ScrollSpeed_U ("ScrollSpeed_U", Float ) = 0
        _ScrollTexColor ("ScrollTexColor", Color) = (0.5,0.5,0.5,1)
        _ScrollSpeed_V ("ScrollSpeed_V", Float ) = 0.2
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            uniform sampler2D _ScrollingTex; uniform float4 _ScrollingTex_ST;
            uniform float _ScrollSpeed_U;
            uniform float4 _ScrollTexColor;
            uniform float _ScrollSpeed_V;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
/////// Vectors:
////// Lighting:
////// Emissive:
                float4 node_3797 = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_7527 = (node_3797.rgb*_Color.rgb);
                float4 node_7857 = _Time + _TimeEditor;
                float4 node_1322 = _Time + _TimeEditor;
                float2 node_387 = float2((i.uv0.r+(node_7857.g*_ScrollSpeed_U)),((node_1322.g*_ScrollSpeed_V)+i.uv0.g));
                float4 node_4993 = tex2D(_ScrollingTex,TRANSFORM_TEX(node_387, _ScrollingTex));
                float3 emissive = (node_7527+(node_7527*(node_4993.rgb*_ScrollTexColor.rgb)));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
